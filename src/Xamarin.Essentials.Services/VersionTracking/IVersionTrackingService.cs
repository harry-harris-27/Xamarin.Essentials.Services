using System;
using System.Collections.Generic;

namespace Xamarin.Essentials
{
    public interface IVersionTrackingService
    {
        bool IsFirstLaunchEver { get; }

        bool IsFirstLaunchForCurrentVersion { get; }

        bool IsFirstLaunchForCurrentBuild { get; }

        string CurrentVersion { get; }

        string CurrentBuild { get; }

        string PreviousVersion { get; }

        string PreviousBuild { get; }

        string FirstInstalledVersion { get; }

        string FirstInstalledBuild { get; }

        IEnumerable<string> VersionHistory { get; }

        IEnumerable<string> BuildHistory { get; }


        bool IsFirstLaunchForVersion(string version);

        bool IsFirstLaunchForBuild(string build);
    }
}
