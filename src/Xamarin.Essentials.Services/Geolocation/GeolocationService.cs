using System;
using System.Threading;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class GeolocationService : IGeolocationService
    {
        public virtual Task<Location> GetLastKnownLocationAsync() => Geolocation.GetLastKnownLocationAsync();

        public virtual Task<Location> GetLocationAsync() => Geolocation.GetLocationAsync();

        public virtual Task<Location> GetLocationAsync(GeolocationRequest request) => Geolocation.GetLocationAsync(request);

        public virtual Task<Location> GetLocationAsync(GeolocationRequest request, CancellationToken cancellationToken)
            => Geolocation.GetLocationAsync(request, cancellationToken);
    }
}
