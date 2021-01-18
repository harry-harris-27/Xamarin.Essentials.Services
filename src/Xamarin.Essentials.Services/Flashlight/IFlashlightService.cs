using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IFlashlightService
    {
        Task TurnOnAsync();
        Task TurnOffAsync();
    }
}
