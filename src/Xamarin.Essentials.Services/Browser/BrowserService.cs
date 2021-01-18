using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class BrowserService : IBrowserService
    {
        public Task OpenAsync(string uri) => Browser.OpenAsync(uri);

        public Task OpenAsync(string uri, BrowserLaunchMode launchMode) => Browser.OpenAsync(uri, launchMode);

        public Task OpenAsync(string uri, BrowserLaunchOptions options) => Browser.OpenAsync(uri, options);

        public Task OpenAsync(Uri uri) => Browser.OpenAsync(uri);

        public Task OpenAsync(Uri uri, BrowserLaunchMode launchMode) => Browser.OpenAsync(uri, launchMode);

        public Task<bool> OpenAsync(Uri uri, BrowserLaunchOptions options) => Browser.OpenAsync(uri, options);
    }
}
