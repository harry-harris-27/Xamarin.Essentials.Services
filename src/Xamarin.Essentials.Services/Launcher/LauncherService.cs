using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class LauncherService : ILauncherService
    {
        public Task<bool> CanOpenAsync(string uri) => Launcher.CanOpenAsync(uri);

        public Task<bool> CanOpenAsync(Uri uri) => Launcher.CanOpenAsync(uri);

        public Task OpenAsync(string uri) => Launcher.OpenAsync(uri);

        public Task OpenAsync(Uri uri) => Launcher.OpenAsync(uri);

        public Task OpenAsync(OpenFileRequest request) => Launcher.OpenAsync(request);

        public Task<bool> TryOpenAsync(string uri) => Launcher.TryOpenAsync(uri);

        public Task<bool> TryOpenAsync(Uri uri) => Launcher.TryOpenAsync(uri);
    }
}
