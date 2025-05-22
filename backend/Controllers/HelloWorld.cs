using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

//Create me a hello world contrpller as API controller

[ApiController]
[Route("api/[controller]")]

public class HelloWorldController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello wooooorrrrrld");
    }

}