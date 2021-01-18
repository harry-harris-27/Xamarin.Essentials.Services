using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class TextToSpeechService : ITextToSpeechService
    {
        public Task<IEnumerable<Locale>> GetLocalesAsync() => TextToSpeech.GetLocalesAsync();

        public Task SpeakAsync(string text, CancellationToken cancellationToken = default) 
            => TextToSpeech.SpeakAsync(text, cancellationToken);

        public Task SpeakAsync(string text, SpeechOptions options, CancellationToken cancellationToken = default)
            => TextToSpeech.SpeakAsync(text, options, cancellationToken);
    }
}
