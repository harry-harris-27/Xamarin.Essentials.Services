using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class BrowserService : IBrowserService
    {
        public virtual Task OpenAsync(string uri) => Browser.OpenAsync(uri);

        public virtual Task OpenAsync(string uri, BrowserLaunchMode launchMode) => Browser.OpenAsync(uri, launchMode);

        public virtual Task OpenAsync(string uri, BrowserLaunchOptions options) => Browser.OpenAsync(uri, options);

        public virtual Task OpenAsync(Uri uri) => Browser.OpenAsync(uri);

        public virtual Task OpenAsync(Uri uri, BrowserLaunchMode launchMode) => Browser.OpenAsync(uri, launchMode);

        public virtual Task<bool> OpenAsync(Uri uri, BrowserLaunchOptions options) => Browser.OpenAsync(uri, options);
    }
}
