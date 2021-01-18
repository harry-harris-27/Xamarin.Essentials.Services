using System;

namespace Xamarin.Essentials
{
    public interface IAppInfoService
    {
        string BuildString { get; }

        string Name { get; }

        string PackageName { get; }

        AppTheme RequestedTheme { get; }

        Version Version { get; }

        string VersionString { get; }


        void ShowSettingsUI();

    }
}
