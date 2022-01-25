using Microsoft.AspNetCore.Mvc;

namespace netcore_api_deployed_on_utopiops.Controllers;

[ApiController]
[Route("/health")]
public class HealthController : ControllerBase
{

    [HttpGet]
    public String Get()
    {
        return "Healthy";
    }
}