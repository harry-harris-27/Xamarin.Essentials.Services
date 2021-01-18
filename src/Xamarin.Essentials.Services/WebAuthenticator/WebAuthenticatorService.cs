using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class WebAuthenticatorService : IWebAuthenticatorService
    {
        public Task<WebAuthenticatorResult> AuthenticateAsync(Uri url, Uri callbackUrl)
            => WebAuthenticator.AuthenticateAsync(url, callbackUrl);
    }
}
