using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using WebRGB.Classes;
using WebRGB.Service;

namespace BlazorApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebRgbController : Controller
    {
        [HttpGet]
        public IEnumerable<DeviceDto> Get()
        {
            var rgbSerice = new RGBService(23);
            return rgbSerice.GetDevices().ToArray();
        }
    }
}
