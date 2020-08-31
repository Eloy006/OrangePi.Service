using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Device.Gpio;
using System.Device.Gpio.Drivers;
using System.Linq;
using System.Threading.Tasks;

namespace OrangePi.Service.Controllers
{
    public class DoorService
    {
        private  GpioController gpio = new GpioController(PinNumberingScheme.Board, new OrangePiZeroDriver());
        public DoorService()
        {
            gpio.OpenPin(7);
            gpio.SetPinMode(7, PinMode.Output);
        }

        public void Open()
        {
            gpio.Write(7, PinValue.High);
        }

        public void Close()
        {
            gpio.Write(7, PinValue.Low);
        }
        

    }
}
