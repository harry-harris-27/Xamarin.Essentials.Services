using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class ClipboardService : IClipboardService
    {
        public bool HasText => Clipboard.HasText;


        public event EventHandler<EventArgs> ClipboardContentChanged
        {
            add => Clipboard.ClipboardContentChanged += value;
            remove => Clipboard.ClipboardContentChanged -= value;
        }


        public Task<string> GetTextAsync() => Clipboard.GetTextAsync();

        public Task SetTextAsync(string text) => Clipboard.SetTextAsync(text);
    }
}
