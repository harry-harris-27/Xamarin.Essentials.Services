using System;

namespace Xamarin.Essentials
{
    public interface IOrientationSensorService
    {
        bool IsMonitoring { get; }

        event EventHandler<OrientationSensorChangedEventArgs> ReadingChanged;

        void Start(SensorSpeed sensorSpeed);

        void Stop();
    }
}
