using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class ShareService : IShareService
    {
        public virtual Task RequestAsync(string text) => Share.RequestAsync(text);

        public virtual Task RequestAsync(string text, string title) => Share.RequestAsync(text, title);

        public virtual Task RequestAsync(ShareTextRequest request) => Share.RequestAsync(request);

        public virtual Task RequestAsync(ShareFileRequest request) => Share.RequestAsync(request);

        public virtual Task RequestAsync(ShareMultipleFilesRequest request) => Share.RequestAsync(request);
    }
}
