using System;

namespace Xamarin.Essentials
{
    public class GyroscopeService : IGyroscopeService
    {
        public virtual bool IsMonitoring => Gyroscope.IsMonitoring;


        public virtual event EventHandler<GyroscopeChangedEventArgs> ReadingChanged
        {
            add => Gyroscope.ReadingChanged += value;
            remove => Gyroscope.ReadingChanged -= value;
        }


        public virtual void Start(SensorSpeed sensorSpeed) => Gyroscope.Start(sensorSpeed);

        public virtual void Stop() => Gyroscope.Stop();
    }
}
