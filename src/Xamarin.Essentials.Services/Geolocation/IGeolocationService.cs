using System;
using System.Threading;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IGeolocationService
    {
        Task<Location> GetLastKnownLocationAsync();

        Task<Location> GetLocationAsync();

        Task<Location> GetLocationAsync(GeolocationRequest request);

        Task<Location> GetLocationAsync(GeolocationRequest request, CancellationToken cancellationToken);
    }
}
