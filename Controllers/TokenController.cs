using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ApiAmaz.Data;
using ApiAmaz.Model;
using ApiAmaz.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace ApiAmaz.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TokenController : ControllerBase
{
    public IConfiguration configuration;
    private readonly AmazDbContext context;

    public TokenController(IConfiguration config, AmazDbContext dbContext)
    {
        configuration = config;
        context = dbContext;
    }

    [HttpPost]
    public async Task<IActionResult> Post(Token userData)
    {
        if (userData != null && userData.Username != null && userData.Password != null)
        {
            var user = await  GetUser(userData.Username,SecurityConfig.ENCRYPTATION_FOR_ASP(userData.Password));

            if (user != null)
            {
                //create claims details based on the user information
                var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("UserId", user.WorkerCode.ToString()),
                    new Claim("DisplayName", user.Worker.Name),
                    new Claim("UserName", user.Username),
                    new Claim("Email", user.Worker.Email)
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    configuration["Jwt:Issuer"],
                    configuration["Jwt:Audience"],
                    claims,
                    expires: DateTime.UtcNow.AddMinutes(10),
                    signingCredentials: signIn);

                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }
            else
            {
                return BadRequest("Invalid credentials");
            }
        }
        else
        {
            return BadRequest();
        }
    }

    private async Task<User> GetUser(string username, string password)
    {
        return await context.Users.Include(p => p.Worker).FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
    }
}