using System;

namespace Xamarin.Essentials
{
    public class VibrationService : IVibrationService
    {
        public void Cancel() => Vibration.Cancel();

        public void Vibrate() => Vibration.Vibrate();

        public void Vibrate(double duration) => Vibration.Vibrate(duration);

        public void Vibrate(TimeSpan duration) => Vibration.Vibrate(duration);
    }
}
