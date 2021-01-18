using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class FlashlightService : IFlashlightService
    {
        public Task TurnOnAsync() => Flashlight.TurnOnAsync();
        public Task TurnOffAsync() => Flashlight.TurnOffAsync();
    }
}
