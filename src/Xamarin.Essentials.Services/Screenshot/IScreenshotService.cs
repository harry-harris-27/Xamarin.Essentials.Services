using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IScreenshotService
    {
        bool IsCaptureSupported { get; }

        Task<ScreenshotResult> CaptureAsync();
    }
}
