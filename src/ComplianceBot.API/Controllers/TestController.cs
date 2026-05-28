using Microsoft.AspNetCore.Mvc;

namespace ComplianceBot.API.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { message = "API is working!" });
    }
}
