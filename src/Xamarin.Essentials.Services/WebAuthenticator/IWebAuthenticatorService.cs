using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IWebAuthenticatorService
    {
        Task<WebAuthenticatorResult> AuthenticateAsync(Uri url, Uri callbackUrl);
    }
}
