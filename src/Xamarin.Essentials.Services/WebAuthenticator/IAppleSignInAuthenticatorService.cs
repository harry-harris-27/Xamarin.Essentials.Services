using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IAppleSignInAuthenticatorService
    {
        Task<WebAuthenticatorResult> AuthenticateAsync(AppleSignInAuthenticator.Options options = null);
    }
}
