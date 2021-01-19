using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class AppleSignInAuthenticatorService : IAppleSignInAuthenticatorService
    {
        public virtual Task<WebAuthenticatorResult> AuthenticateAsync(AppleSignInAuthenticator.Options options = null)
            => AppleSignInAuthenticator.AuthenticateAsync(options);
    }
}
