using MemberCalerExp.Service;
using Microsoft.AspNetCore.Mvc;

namespace MemberCallerExp.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class FirstController : ControllerBase
{
    private readonly ILogger<FirstController> _logger;

    public FirstController(ILogger<FirstController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        //return Ok(SharedLib.WhosCalling());
        return Ok(FirstService.CallIt());
    }
}
