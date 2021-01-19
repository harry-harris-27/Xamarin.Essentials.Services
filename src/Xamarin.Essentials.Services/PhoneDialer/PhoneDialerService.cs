using System;

namespace Xamarin.Essentials
{
    public class PhoneDialerService : IPhoneDialerService
    {
        public virtual void Open(string number) => PhoneDialer.Open(number);
    }
}
