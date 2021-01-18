using System;

namespace Xamarin.Essentials
{
    public class HapticFeedbackService : IHapticFeedbackService
    {
        public void Perform(HapticFeedbackType type = HapticFeedbackType.Click) 
            => HapticFeedback.Perform(type);
    }
}
