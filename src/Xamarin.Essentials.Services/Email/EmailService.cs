using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class EmailService : IEmailService
    {
        public Task ComposeAsync() => Email.ComposeAsync();

        public Task ComposeAsync(string subject, string body, params string[] to) => Email.ComposeAsync(subject, body, to);

        public Task ComposeAsync(EmailMessage message) => Email.ComposeAsync(message);
    }
}
