using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class SmsService : ISmsService
    {
        public virtual Task ComposeAsync() => Sms.ComposeAsync();

        public virtual Task ComposeAsync(SmsMessage message) => Sms.ComposeAsync(message);
    }
}
