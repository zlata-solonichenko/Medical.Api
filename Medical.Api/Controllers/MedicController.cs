using Microsoft.AspNetCore.Mvc;

namespace Medical.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class MedicController : ControllerBase
{
    public MedicController(ILogger<MedicController> logger)
    {
        
    }

}