using System;

namespace Xamarin.Essentials
{
    public class OrientationSensorService : IOrientationSensorService
    {
        public virtual bool IsMonitoring => OrientationSensor.IsMonitoring;


        public virtual event EventHandler<OrientationSensorChangedEventArgs> ReadingChanged
        {
            add => OrientationSensor.ReadingChanged += value;
            remove => OrientationSensor.ReadingChanged -= value;
        }


        public virtual void Start(SensorSpeed sensorSpeed) => OrientationSensor.Start(sensorSpeed);

        public virtual void Stop() => OrientationSensor.Stop();
    }
}
