using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OrangePi.Service.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DoorController : ControllerBase
    {
        private readonly ILogger<DoorController> _logger;

        public DoorController(ILogger<DoorController> logger)
        {
            _logger = logger;
        }

        [HttpPost("open")]
        public IActionResult Open()
        {
            _logger.LogInformation("Hello World!");

            return Ok();
        }
    }
}
