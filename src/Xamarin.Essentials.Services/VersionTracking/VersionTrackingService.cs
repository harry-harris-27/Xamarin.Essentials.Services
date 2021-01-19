using System;
using System.Collections.Generic;

namespace Xamarin.Essentials
{
    public class VersionTrackingService : IVersionTrackingService
    {
        public virtual bool IsFirstLaunchEver => VersionTracking.IsFirstLaunchEver;

        public virtual bool IsFirstLaunchForCurrentVersion => VersionTracking.IsFirstLaunchForCurrentVersion;

        public virtual bool IsFirstLaunchForCurrentBuild => VersionTracking.IsFirstLaunchForCurrentBuild;

        public virtual string CurrentVersion => VersionTracking.CurrentVersion;

        public virtual string CurrentBuild => VersionTracking.CurrentBuild;

        public virtual string PreviousVersion => VersionTracking.PreviousVersion;

        public virtual string PreviousBuild => VersionTracking.PreviousBuild;

        public virtual string FirstInstalledVersion => VersionTracking.FirstInstalledVersion;

        public virtual string FirstInstalledBuild => VersionTracking.FirstInstalledBuild;

        public virtual IEnumerable<string> VersionHistory => VersionTracking.VersionHistory;

        public virtual IEnumerable<string> BuildHistory => VersionTracking.BuildHistory;


        public virtual bool IsFirstLaunchForBuild(string build) => VersionTracking.IsFirstLaunchForBuild(build);

        public virtual bool IsFirstLaunchForVersion(string version) => VersionTracking.IsFirstLaunchForVersion(version);
    }
}
