using System;
using System.Collections.Generic;

namespace Xamarin.Essentials
{
    public class VersionTrackingService : IVersionTrackingService
    {
        public bool IsFirstLaunchEver => VersionTracking.IsFirstLaunchEver;

        public bool IsFirstLaunchForCurrentVersion => VersionTracking.IsFirstLaunchForCurrentVersion;

        public bool IsFirstLaunchForCurrentBuild => VersionTracking.IsFirstLaunchForCurrentBuild;

        public string CurrentVersion => VersionTracking.CurrentVersion;

        public string CurrentBuild => VersionTracking.CurrentBuild;

        public string PreviousVersion => VersionTracking.PreviousVersion;

        public string PreviousBuild => VersionTracking.PreviousBuild;

        public string FirstInstalledVersion => VersionTracking.FirstInstalledVersion;

        public string FirstInstalledBuild => VersionTracking.FirstInstalledBuild;

        public IEnumerable<string> VersionHistory => VersionTracking.VersionHistory;

        public IEnumerable<string> BuildHistory => VersionTracking.BuildHistory;


        public bool IsFirstLaunchForBuild(string build) => VersionTracking.IsFirstLaunchForBuild(build);

        public bool IsFirstLaunchForVersion(string version) => VersionTracking.IsFirstLaunchForVersion(version);
    }
}
