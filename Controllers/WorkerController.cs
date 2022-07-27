using System.Net;
using ApiAmaz.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiAmaz.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class WorkerController : ControllerBase
{
    IWorkerService workerService;

    public WorkerController(IWorkerService service)
    {
        workerService = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(workerService.Get());    
    }

}