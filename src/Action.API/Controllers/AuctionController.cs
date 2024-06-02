using Microsoft.AspNetCore.Mvc;

namespace Action.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCurrentAuction() 
    {
        return Ok("Franklin");
    }
}
