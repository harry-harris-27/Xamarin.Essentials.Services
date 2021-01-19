using System;

namespace Xamarin.Essentials
{
    public class VibrationService : IVibrationService
    {
        public virtual void Cancel() => Vibration.Cancel();

        public virtual void Vibrate() => Vibration.Vibrate();

        public virtual void Vibrate(double duration) => Vibration.Vibrate(duration);

        public virtual void Vibrate(TimeSpan duration) => Vibration.Vibrate(duration);
    }
}
