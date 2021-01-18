using System;

namespace Xamarin.Essentials
{
    public interface IMagnetometerService
    {
        bool IsMonitoring { get; }

     
        event EventHandler<MagnetometerChangedEventArgs> ReadingChanged;


        void Start(SensorSpeed sensorSpeed);

        void Stop();
    }
}
