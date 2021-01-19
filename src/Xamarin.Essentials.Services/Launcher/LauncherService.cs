using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class LauncherService : ILauncherService
    {
        public virtual Task<bool> CanOpenAsync(string uri) => Launcher.CanOpenAsync(uri);

        public virtual Task<bool> CanOpenAsync(Uri uri) => Launcher.CanOpenAsync(uri);

        public virtual Task OpenAsync(string uri) => Launcher.OpenAsync(uri);

        public virtual Task OpenAsync(Uri uri) => Launcher.OpenAsync(uri);

        public virtual Task OpenAsync(OpenFileRequest request) => Launcher.OpenAsync(request);

        public virtual Task<bool> TryOpenAsync(string uri) => Launcher.TryOpenAsync(uri);

        public virtual Task<bool> TryOpenAsync(Uri uri) => Launcher.TryOpenAsync(uri);
    }
}
