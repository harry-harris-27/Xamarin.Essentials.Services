using System;

namespace Xamarin.Essentials
{
    public interface IDeviceInfoService
    {
        string Model { get; }

        string Manufacturer { get; }

        string Name { get; }

        string VersionString { get; }

        Version Version { get; }

        DevicePlatform Platform { get; }

        DeviceIdiom Idiom { get; }

        DeviceType DeviceType { get; }
    }
}
