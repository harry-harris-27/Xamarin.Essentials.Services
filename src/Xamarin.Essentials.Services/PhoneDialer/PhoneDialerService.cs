using System;

namespace Xamarin.Essentials
{
    public class PhoneDialerService : IPhoneDialerService
    {
        public void Open(string number) => PhoneDialer.Open(number);
    }
}
