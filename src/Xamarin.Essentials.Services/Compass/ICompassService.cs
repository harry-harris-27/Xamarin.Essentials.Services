using System;

namespace Xamarin.Essentials
{
    public interface ICompassService
    {
        bool IsMonitoring { get; }

        
        event EventHandler<CompassChangedEventArgs> ReadingChanged;


        void Start(SensorSpeed sensorSpeed);

        void Start(SensorSpeed sensorSpeed, bool applyLowPassFilter);

        void Stop();
    }
}
