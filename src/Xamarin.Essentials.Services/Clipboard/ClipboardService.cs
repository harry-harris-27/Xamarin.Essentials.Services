using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class ClipboardService : IClipboardService
    {
        public virtual bool HasText => Clipboard.HasText;


        public virtual event EventHandler<EventArgs> ClipboardContentChanged
        {
            add => Clipboard.ClipboardContentChanged += value;
            remove => Clipboard.ClipboardContentChanged -= value;
        }


        public virtual Task<string> GetTextAsync() => Clipboard.GetTextAsync();

        public virtual Task SetTextAsync(string text) => Clipboard.SetTextAsync(text);
    }
}
