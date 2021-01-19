using System;
using System.Collections.Generic;

namespace Xamarin.Essentials
{
    public class ConnectivityService : IConnectivityService
    {
        public virtual NetworkAccess NetworkAccess => Connectivity.NetworkAccess;

        public virtual IEnumerable<ConnectionProfile> ConnectionProfiles => Connectivity.ConnectionProfiles;


        public virtual event EventHandler<ConnectivityChangedEventArgs> ConnectivityChanged
        {
            add => Connectivity.ConnectivityChanged += value;
            remove => Connectivity.ConnectivityChanged -= value;        
        }
    }
}
