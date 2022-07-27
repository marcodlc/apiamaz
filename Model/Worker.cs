using System.Text.Json.Serialization;

namespace ApiAmaz.Model;

public class Worker : Audit
{
    public Guid Code { get; set; }
    public string Name { get; set; }
    public Guid RoleCode { get; set; }
    public string Email { get; set; }
    public bool isActive { get; set; }
    public virtual Role Role { get; set; }
    [JsonIgnore]
    public virtual ICollection<User> Users {get;set;}
}