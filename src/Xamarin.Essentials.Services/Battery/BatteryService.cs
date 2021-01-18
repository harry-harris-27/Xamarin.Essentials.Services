using System;

namespace Xamarin.Essentials
{
    public class BatteryService : IBatteryService
    {
        public double ChargeLevel => Battery.ChargeLevel;

        public BatteryState State => Battery.State;

        public BatteryPowerSource PowerSource => Battery.PowerSource;

        public EnergySaverStatus EnergySaverStatus => Battery.EnergySaverStatus;


        public event EventHandler<BatteryInfoChangedEventArgs> BatteryInfoChanged
        {
            add => Battery.BatteryInfoChanged += value;
            remove => Battery.BatteryInfoChanged -= value;
        }

        public event EventHandler<EnergySaverStatusChangedEventArgs> EnergySaverStatusChanged
        {
            add => Battery.EnergySaverStatusChanged += value;
            remove => Battery.EnergySaverStatusChanged -= value;
        }
    }
}
