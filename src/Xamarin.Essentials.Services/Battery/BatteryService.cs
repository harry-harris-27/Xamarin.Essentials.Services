using System;

namespace Xamarin.Essentials
{
    public class BatteryService : IBatteryService
    {
        public virtual double ChargeLevel => Battery.ChargeLevel;

        public virtual BatteryState State => Battery.State;

        public virtual BatteryPowerSource PowerSource => Battery.PowerSource;

        public virtual EnergySaverStatus EnergySaverStatus => Battery.EnergySaverStatus;


        public virtual event EventHandler<BatteryInfoChangedEventArgs> BatteryInfoChanged
        {
            add => Battery.BatteryInfoChanged += value;
            remove => Battery.BatteryInfoChanged -= value;
        }

        public virtual event EventHandler<EnergySaverStatusChangedEventArgs> EnergySaverStatusChanged
        {
            add => Battery.EnergySaverStatusChanged += value;
            remove => Battery.EnergySaverStatusChanged -= value;
        }
    }
}
