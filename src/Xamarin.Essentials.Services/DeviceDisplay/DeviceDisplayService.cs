using System;

namespace Xamarin.Essentials
{
    public class DeviceDisplayService : IDeviceDisplayService
    {
        public virtual bool KeepScreenOn 
        {
            get => DeviceDisplay.KeepScreenOn;
            set => DeviceDisplay.KeepScreenOn = value;
        }

        public virtual DisplayInfo MainDisplayInfo => DeviceDisplay.MainDisplayInfo;


        public virtual event EventHandler<DisplayInfoChangedEventArgs> MainDisplayInfoChanged
        {
            add => DeviceDisplay.MainDisplayInfoChanged += value;
            remove => DeviceDisplay.MainDisplayInfoChanged -= value;
        }
    }
}
