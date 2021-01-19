using System;

namespace Xamarin.Essentials
{
    public class HapticFeedbackService : IHapticFeedbackService
    {
        public virtual void Perform(HapticFeedbackType type = HapticFeedbackType.Click) 
            => HapticFeedback.Perform(type);
    }
}
