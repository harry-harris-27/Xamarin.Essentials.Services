using System;

namespace Xamarin.Essentials
{
    public class CompassService : ICompassService
    {
        public virtual bool IsMonitoring => Compass.IsMonitoring;


        public virtual event EventHandler<CompassChangedEventArgs> ReadingChanged
        {
            add => Compass.ReadingChanged += value;
            remove => Compass.ReadingChanged -= value;
        }


        public virtual void Start(SensorSpeed sensorSpeed) => Compass.Start(sensorSpeed);

        public virtual void Start(SensorSpeed sensorSpeed, bool applyLowPassFilter) => Compass.Start(sensorSpeed, applyLowPassFilter);

        public virtual void Stop() => Compass.Stop();
    }
}
