using System;

namespace Xamarin.Essentials
{
    public class AccelerometerService : IAccelerometerService
    {
        public bool IsMonitoring => Accelerometer.IsMonitoring;


        public event EventHandler<AccelerometerChangedEventArgs> ReadingChanged
        {
            add => Accelerometer.ReadingChanged += value;
            remove => Accelerometer.ReadingChanged -= value;
        }

        public event EventHandler ShakeDetected
        {
            add => Accelerometer.ShakeDetected += value;
            remove => Accelerometer.ShakeDetected -= value;
        }


        public void Start(SensorSpeed sensorSpeed) => Accelerometer.Start(sensorSpeed);

        public void Stop() => Accelerometer.Stop();

    }
}
