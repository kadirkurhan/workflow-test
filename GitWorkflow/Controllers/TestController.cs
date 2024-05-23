using Microsoft.AspNetCore.Mvc;

namespace GitWorkflow.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    public TestController()
    {
    }

    [HttpGet]
    public string Get(int request)
    {
        if(request % 2 == 0)
        {
            return "odd1";
        }

        return "even";
    }
}

