using OpenRGB.NET;
using OpenRGB.NET.Models;
using System;

namespace WebRGB.Service
{
    public class RGBService
    {
        private int Leds;
        public RGBService(int leds)
        {
            Leds = leds;
        }
        public void Test()
        {
            using OpenRGBClient client = new OpenRGBClient(name: "Ao");
            var controllers = client.GetControllerCount();
            var colors = new Color[Leds];
            var rand = new Random();
            for (int i = 0; i < Leds; i++)
            {
                var r = rand.Next(255);
                var g = rand.Next(255);
                var b = rand.Next(255);
                colors[i] = new Color((byte)r, (byte)g, (byte)b);
            }
            for (int i = 0; i < controllers; i++)
            {
                client.UpdateLeds(i, colors);
            }
        }
    }
}
