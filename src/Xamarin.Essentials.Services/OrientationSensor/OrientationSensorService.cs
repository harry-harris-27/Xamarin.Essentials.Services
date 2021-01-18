using System;

namespace Xamarin.Essentials
{
    public class OrientationSensorService : IOrientationSensorService
    {
        public bool IsMonitoring => OrientationSensor.IsMonitoring;


        public event EventHandler<OrientationSensorChangedEventArgs> ReadingChanged
        {
            add => OrientationSensor.ReadingChanged += value;
            remove => OrientationSensor.ReadingChanged -= value;
        }


        public void Start(SensorSpeed sensorSpeed) => OrientationSensor.Start(sensorSpeed);

        public void Stop() => OrientationSensor.Stop();
    }
}
