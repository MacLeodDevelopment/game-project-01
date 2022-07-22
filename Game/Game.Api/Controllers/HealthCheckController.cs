using Game.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Game.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthCheckController : Controller
{
    [HttpGet]
    public OkObjectResult Get()
    {
        var versionNumber = new VersionNumber();
        return Ok(versionNumber);
    }
}