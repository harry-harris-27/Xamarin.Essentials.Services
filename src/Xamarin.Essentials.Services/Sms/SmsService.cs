using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class SmsService : ISmsService
    {
        public Task ComposeAsync() => Sms.ComposeAsync();

        public Task ComposeAsync(SmsMessage message) => Sms.ComposeAsync(message);
    }
}
