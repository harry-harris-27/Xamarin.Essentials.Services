using System;

namespace Xamarin.Essentials
{
    public interface IBarometerService
    {
        bool IsMonitoring { get; }

        
        event EventHandler<BarometerChangedEventArgs> ReadingChanged;


        void Start(SensorSpeed sensorSpeed);

        void Stop();
    }
}
