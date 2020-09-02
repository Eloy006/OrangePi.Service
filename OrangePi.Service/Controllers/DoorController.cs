using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Device.Gpio;
using System.Device.Gpio.Drivers;
using System.Threading;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Open()
        {
            _logger.LogInformation("Begin open");
            _service.Open();
            _logger.LogInformation("Wait 1sec"); 
            await Task.Delay(1000);
            _logger.LogInformation("close");
            _service.Close();

            return Ok();
        }
    }
}
