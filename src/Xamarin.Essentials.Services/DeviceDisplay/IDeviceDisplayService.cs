using System;

namespace Xamarin.Essentials
{
    public interface IDeviceDisplayService
    {
        bool KeepScreenOn { get; set; }

        DisplayInfo MainDisplayInfo { get; }


        event EventHandler<DisplayInfoChangedEventArgs> MainDisplayInfoChanged;
    }
}
