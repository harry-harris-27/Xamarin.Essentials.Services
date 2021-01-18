using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface ITextToSpeechService
    {
        Task<IEnumerable<Locale>> GetLocalesAsync();

        Task SpeakAsync(string text, CancellationToken cancellationToken = default);

        Task SpeakAsync(string text, SpeechOptions options, CancellationToken cancellationToken = default);
    }
}
