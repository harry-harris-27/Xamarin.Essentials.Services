using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IEmailService
    {
        Task ComposeAsync();

        Task ComposeAsync(string subject, string body, params string[] to);

        Task ComposeAsync(EmailMessage message);
    }
}
