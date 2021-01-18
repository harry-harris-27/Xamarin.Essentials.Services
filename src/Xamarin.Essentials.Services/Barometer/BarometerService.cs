using System;

namespace Xamarin.Essentials
{
    public class BarometerService : IBarometerService
    {
        public bool IsMonitoring => Barometer.IsMonitoring;


        public event EventHandler<BarometerChangedEventArgs> ReadingChanged
        {
            add => Barometer.ReadingChanged += value;
            remove => Barometer.ReadingChanged -= value;
        }


        public void Start(SensorSpeed sensorSpeed) => Barometer.Start(sensorSpeed);

        public void Stop() => Barometer.Stop();
    }
}
