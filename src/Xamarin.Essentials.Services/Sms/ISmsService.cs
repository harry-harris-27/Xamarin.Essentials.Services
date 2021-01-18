using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface ISmsService
    {
        Task ComposeAsync();

        Task ComposeAsync(SmsMessage message);
    }
}
