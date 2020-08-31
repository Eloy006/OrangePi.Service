using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Device.Gpio;
using System.Device.Gpio.Drivers;

namespace OrangePi.Service.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DoorController : ControllerBase
    {
        DoorService _service;


        private readonly ILogger<DoorController> _logger;

        public DoorController(ILogger<DoorController> logger,DoorService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("close")]
        public IActionResult Close()
        {
            // Write a value to the pin.
            _service.Close();
            _logger.LogInformation("Hello World!");

            return Ok();
        }

        [HttpPost("open")]
        public IActionResult Open()
        {
            _service.Open();
            _logger.LogInformation("Hello World!");

            return Ok();
        }
    }
}
