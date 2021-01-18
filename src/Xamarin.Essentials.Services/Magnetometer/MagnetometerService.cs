using System;

namespace Xamarin.Essentials
{
    public class MagnetometerService : IMagnetometerService
    {
        public bool IsMonitoring => Magnetometer.IsMonitoring;


        public event EventHandler<MagnetometerChangedEventArgs> ReadingChanged
        {
            add => Magnetometer.ReadingChanged += value;
            remove => Magnetometer.ReadingChanged -= value;
        }


        public void Start(SensorSpeed sensorSpeed) => Magnetometer.Start(sensorSpeed);

        public void Stop() => Magnetometer.Stop();
    }
}
