using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRGB.Service;

namespace BlazorApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebRgbController : Controller
    {
        [HttpGet]
        public void Get()
        {
            var rgbSerice = new RGBService(23);
            rgbSerice.Test();
        }
    }
}
