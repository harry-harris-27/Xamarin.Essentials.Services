using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IGeocodingService
    {
        Task<IEnumerable<Placemark>> GetPlacemarksAsync(Location location);

        Task<IEnumerable<Placemark>> GetPlacemarksAsync(double latitude, double longitude);

        Task<IEnumerable<Location>> GetLocationsAsync(string address);
    }
}
