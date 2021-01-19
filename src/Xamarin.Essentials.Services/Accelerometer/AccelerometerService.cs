using System;

namespace Xamarin.Essentials
{
    public class AccelerometerService : IAccelerometerService
    {
        public virtual bool IsMonitoring => Accelerometer.IsMonitoring;


        public virtual event EventHandler<AccelerometerChangedEventArgs> ReadingChanged
        {
            add => Accelerometer.ReadingChanged += value;
            remove => Accelerometer.ReadingChanged -= value;
        }

        public virtual event EventHandler ShakeDetected
        {
            add => Accelerometer.ShakeDetected += value;
            remove => Accelerometer.ShakeDetected -= value;
        }


        public virtual void Start(SensorSpeed sensorSpeed) => Accelerometer.Start(sensorSpeed);

        public virtual void Stop() => Accelerometer.Stop();

    }
}
