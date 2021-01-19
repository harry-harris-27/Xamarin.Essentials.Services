using System;

namespace Xamarin.Essentials
{
    public class MagnetometerService : IMagnetometerService
    {
        public virtual bool IsMonitoring => Magnetometer.IsMonitoring;


        public virtual event EventHandler<MagnetometerChangedEventArgs> ReadingChanged
        {
            add => Magnetometer.ReadingChanged += value;
            remove => Magnetometer.ReadingChanged -= value;
        }


        public virtual void Start(SensorSpeed sensorSpeed) => Magnetometer.Start(sensorSpeed);

        public virtual void Stop() => Magnetometer.Stop();
    }
}
