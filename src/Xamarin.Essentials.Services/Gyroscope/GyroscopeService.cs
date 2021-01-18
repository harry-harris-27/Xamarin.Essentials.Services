using System;

namespace Xamarin.Essentials
{
    public class GyroscopeService : IGyroscopeService
    {
        public bool IsMonitoring => Gyroscope.IsMonitoring;

        
        public event EventHandler<GyroscopeChangedEventArgs> ReadingChanged
        {
            add => Gyroscope.ReadingChanged += value;
            remove => Gyroscope.ReadingChanged -= value;
        }


        public void Start(SensorSpeed sensorSpeed) => Gyroscope.Start(sensorSpeed);

        public void Stop() => Gyroscope.Stop();
    }
}
