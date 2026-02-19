using Microsoft.AspNetCore.Mvc;

namespace HypothesisHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello from Cursor!");
    }
}
