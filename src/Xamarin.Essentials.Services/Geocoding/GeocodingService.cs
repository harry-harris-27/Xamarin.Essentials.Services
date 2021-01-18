using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class GeocodingService : IGeocodingService
    {
        public Task<IEnumerable<Location>> GetLocationsAsync(string address)
            => Geocoding.GetLocationsAsync(address);

        public Task<IEnumerable<Placemark>> GetPlacemarksAsync(Location location)
            => Geocoding.GetPlacemarksAsync(location);

        public Task<IEnumerable<Placemark>> GetPlacemarksAsync(double latitude, double longitude)
            => Geocoding.GetPlacemarksAsync(latitude, longitude);
    }
}
