using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IClipboardService
    {
        bool HasText { get; }

        
        event EventHandler<EventArgs> ClipboardContentChanged;


        Task<string> GetTextAsync();

        Task SetTextAsync(string text);
    }
}
