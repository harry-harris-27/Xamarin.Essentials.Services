using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface ILauncherService
    {
        Task<bool> CanOpenAsync(string uri);

        Task<bool> CanOpenAsync(Uri uri);

        Task OpenAsync(string uri);

        Task OpenAsync(Uri uri);

        Task OpenAsync(OpenFileRequest request);

        Task<bool> TryOpenAsync(string uri);

        Task<bool> TryOpenAsync(Uri uri);
    }
}
