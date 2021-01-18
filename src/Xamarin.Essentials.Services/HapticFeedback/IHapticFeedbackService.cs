using System;

namespace Xamarin.Essentials
{
    public interface IHapticFeedbackService
    {
        void Perform(HapticFeedbackType type = HapticFeedbackType.Click);
    }
}
