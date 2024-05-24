using Microsoft.AspNetCore.Mvc;

namespace GitWorkflow.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    public TestController()
    {
    }

    [HttpGet("Current")]
    public string IsOddOrEven(int request)
    {
        if(request % 2 != 0)
        {
            return "even";
        }

        return "odd";
    }


    [HttpGet]
    public string Get()
    {
        return "Hello World";
    }
    
}

