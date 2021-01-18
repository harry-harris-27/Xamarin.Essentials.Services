using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IShareService
    {
        Task RequestAsync(string text);

        Task RequestAsync(string text, string title);

        Task RequestAsync(ShareTextRequest request);

        Task RequestAsync(ShareFileRequest request);

        Task RequestAsync(ShareMultipleFilesRequest request);
    }
}
