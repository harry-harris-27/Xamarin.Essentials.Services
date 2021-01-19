using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class WebAuthenticatorService : IWebAuthenticatorService
    {
        public virtual Task<WebAuthenticatorResult> AuthenticateAsync(Uri url, Uri callbackUrl)
            => WebAuthenticator.AuthenticateAsync(url, callbackUrl);
    }
}
