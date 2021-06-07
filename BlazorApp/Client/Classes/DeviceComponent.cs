using Microsoft.AspNetCore.Components;

namespace BlazorApp.Client.Classes
{
    public class DeviceComponent : ComponentBase
    {
        [Parameter]
        public string Name { get; set; }

        [Parameter]
        public string Type { get; set; }
    }
}
