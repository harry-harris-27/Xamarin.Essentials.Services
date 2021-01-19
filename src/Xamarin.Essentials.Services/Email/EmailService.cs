using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class EmailService : IEmailService
    {
        public virtual Task ComposeAsync() => Email.ComposeAsync();

        public virtual Task ComposeAsync(string subject, string body, params string[] to) => Email.ComposeAsync(subject, body, to);

        public virtual Task ComposeAsync(EmailMessage message) => Email.ComposeAsync(message);
    }
}
