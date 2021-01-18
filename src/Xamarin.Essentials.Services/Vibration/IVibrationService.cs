using System;

namespace Xamarin.Essentials
{
    public interface IVibrationService
    {
        void Vibrate();

        void Vibrate(double duration);

        void Vibrate(TimeSpan duration);

        void Cancel();
    }
}
