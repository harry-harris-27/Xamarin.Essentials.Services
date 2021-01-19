using System;

namespace Xamarin.Essentials
{
    public class AppInfoService : IAppInfoService
    {
        public virtual string BuildString => AppInfo.BuildString;

        public virtual string Name => AppInfo.Name;

        public virtual string PackageName => AppInfo.PackageName;

        public virtual AppTheme RequestedTheme => AppInfo.RequestedTheme;

        public virtual Version Version => AppInfo.Version;

        public virtual string VersionString => AppInfo.VersionString;


        public virtual void ShowSettingsUI() => AppInfo.ShowSettingsUI();

    }
}
