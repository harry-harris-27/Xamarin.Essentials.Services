using System;

namespace Xamarin.Essentials
{
    public interface IAccelerometerService
    {

        event EventHandler<AccelerometerChangedEventArgs> ReadingChanged;

        event EventHandler ShakeDetected;

        bool IsMonitoring { get; }

        void Start(SensorSpeed sensorSpeed);

        void Stop();

    }
}
