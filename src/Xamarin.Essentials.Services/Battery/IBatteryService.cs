using System;

namespace Xamarin.Essentials
{
    public interface IBatteryService
    {
        double ChargeLevel { get; }

        BatteryState State { get; }

        BatteryPowerSource PowerSource { get; }

        EnergySaverStatus EnergySaverStatus { get; }


        event EventHandler<BatteryInfoChangedEventArgs> BatteryInfoChanged;

        event EventHandler<EnergySaverStatusChangedEventArgs> EnergySaverStatusChanged;
    }
}
