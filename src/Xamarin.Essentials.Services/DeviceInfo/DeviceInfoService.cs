using System;

namespace Xamarin.Essentials
{
    public class DeviceInfoService : IDeviceInfoService
    {
        public virtual string Model => DeviceInfo.Model;

        public virtual string Manufacturer => DeviceInfo.Manufacturer;

        public virtual string Name => DeviceInfo.Name;

        public virtual string VersionString => DeviceInfo.VersionString;

        public virtual Version Version => DeviceInfo.Version;

        public virtual DevicePlatform Platform => DeviceInfo.Platform;

        public virtual DeviceIdiom Idiom => DeviceInfo.Idiom;

        public virtual DeviceType DeviceType => DeviceInfo.DeviceType;
    }
}
