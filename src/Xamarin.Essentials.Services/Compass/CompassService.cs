using System;

namespace Xamarin.Essentials
{
    public class CompassService : ICompassService
    {
        public bool IsMonitoring => Compass.IsMonitoring;


        public event EventHandler<CompassChangedEventArgs> ReadingChanged
        {
            add => Compass.ReadingChanged += value;
            remove => Compass.ReadingChanged -= value;
        }


        public void Start(SensorSpeed sensorSpeed) => Compass.Start(sensorSpeed);

        public void Start(SensorSpeed sensorSpeed, bool applyLowPassFilter) => Compass.Start(sensorSpeed, applyLowPassFilter);

        public void Stop() => Compass.Stop();
    }
}
