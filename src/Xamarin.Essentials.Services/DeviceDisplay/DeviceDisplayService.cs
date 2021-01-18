using System;

namespace Xamarin.Essentials
{
    public class DeviceDisplayService : IDeviceDisplayService
    {
        public bool KeepScreenOn 
        {
            get => DeviceDisplay.KeepScreenOn;
            set => DeviceDisplay.KeepScreenOn = value;
        }

        public DisplayInfo MainDisplayInfo => DeviceDisplay.MainDisplayInfo;


        public event EventHandler<DisplayInfoChangedEventArgs> MainDisplayInfoChanged
        {
            add => DeviceDisplay.MainDisplayInfoChanged += value;
            remove => DeviceDisplay.MainDisplayInfoChanged -= value;
        }
    }
}
