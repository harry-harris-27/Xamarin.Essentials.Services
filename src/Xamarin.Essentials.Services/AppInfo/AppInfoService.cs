using System;

namespace Xamarin.Essentials
{
    public class AppInfoService : IAppInfoService
    {
        public string BuildString => AppInfo.BuildString;

        public string Name => AppInfo.Name;

        public string PackageName => AppInfo.PackageName;

        public AppTheme RequestedTheme => AppInfo.RequestedTheme;

        public Version Version => AppInfo.Version;

        public string VersionString => AppInfo.VersionString;

        
        public void ShowSettingsUI() => AppInfo.ShowSettingsUI();

    }
}
