using System;

namespace Xamarin.Essentials
{
    public interface IGyroscopeService
    {
        bool IsMonitoring { get; }

        event EventHandler<GyroscopeChangedEventArgs> ReadingChanged;

        void Start(SensorSpeed sensorSpeed);

        void Stop();
    }
}
