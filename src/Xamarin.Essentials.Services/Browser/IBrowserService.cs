using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IBrowserService
    {
        Task OpenAsync(string uri);

        Task OpenAsync(string uri, BrowserLaunchMode launchMode);

        Task OpenAsync(string uri, BrowserLaunchOptions options);

        Task OpenAsync(Uri uri);

        Task OpenAsync(Uri uri, BrowserLaunchMode launchMode);

        Task<bool> OpenAsync(Uri uri, BrowserLaunchOptions options);
    }
}
