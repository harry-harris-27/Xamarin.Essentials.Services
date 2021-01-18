using System;
using System.Threading;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class GeolocationService : IGeolocationService
    {
        public Task<Location> GetLastKnownLocationAsync() => Geolocation.GetLastKnownLocationAsync();

        public Task<Location> GetLocationAsync() => Geolocation.GetLocationAsync();

        public Task<Location> GetLocationAsync(GeolocationRequest request) => Geolocation.GetLocationAsync(request);

        public Task<Location> GetLocationAsync(GeolocationRequest request, CancellationToken cancellationToken)
            => Geolocation.GetLocationAsync(request, cancellationToken);
    }
}
