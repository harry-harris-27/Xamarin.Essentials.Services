using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class TextToSpeechService : ITextToSpeechService
    {
        public virtual Task<IEnumerable<Locale>> GetLocalesAsync() => TextToSpeech.GetLocalesAsync();

        public virtual Task SpeakAsync(string text, CancellationToken cancellationToken = default) 
            => TextToSpeech.SpeakAsync(text, cancellationToken);

        public virtual Task SpeakAsync(string text, SpeechOptions options, CancellationToken cancellationToken = default)
            => TextToSpeech.SpeakAsync(text, options, cancellationToken);
    }
}
