namespace EDH_GPT.API.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class MTGJsonController : ControllerBase
{
    private readonly ILogger<MTGJsonController> _logger;

    public MTGJsonController(ILogger<MTGJsonController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Get all")]
    public string Get()
    {
        return "Hello world";
    }
}
