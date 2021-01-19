using System;

namespace Xamarin.Essentials
{
    public class BarometerService : IBarometerService
    {
        public virtual bool IsMonitoring => Barometer.IsMonitoring;


        public virtual event EventHandler<BarometerChangedEventArgs> ReadingChanged
        {
            add => Barometer.ReadingChanged += value;
            remove => Barometer.ReadingChanged -= value;
        }


        public virtual void Start(SensorSpeed sensorSpeed) => Barometer.Start(sensorSpeed);

        public virtual void Stop() => Barometer.Stop();
    }
}
