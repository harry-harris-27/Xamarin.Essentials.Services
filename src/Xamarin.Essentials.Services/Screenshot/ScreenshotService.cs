using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class ScreenshotService : IScreenshotService
    {
        public virtual bool IsCaptureSupported => Screenshot.IsCaptureSupported;

        public virtual Task<ScreenshotResult> CaptureAsync() => Screenshot.CaptureAsync();
    }
}
