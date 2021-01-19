using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class FlashlightService : IFlashlightService
    {
        public virtual Task TurnOnAsync() => Flashlight.TurnOnAsync();
        public virtual Task TurnOffAsync() => Flashlight.TurnOffAsync();
    }
}
