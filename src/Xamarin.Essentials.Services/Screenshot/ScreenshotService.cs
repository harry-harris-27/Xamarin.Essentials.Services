using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class ScreenshotService : IScreenshotService
    {
        public bool IsCaptureSupported => Screenshot.IsCaptureSupported;

        public Task<ScreenshotResult> CaptureAsync() => Screenshot.CaptureAsync();
    }
}
