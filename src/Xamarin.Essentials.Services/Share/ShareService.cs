using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class ShareService : IShareService
    {
        public Task RequestAsync(string text) => Share.RequestAsync(text);

        public Task RequestAsync(string text, string title) => Share.RequestAsync(text, title);

        public Task RequestAsync(ShareTextRequest request) => Share.RequestAsync(request);

        public Task RequestAsync(ShareFileRequest request) => Share.RequestAsync(request);

        public Task RequestAsync(ShareMultipleFilesRequest request) => Share.RequestAsync(request);
    }
}
