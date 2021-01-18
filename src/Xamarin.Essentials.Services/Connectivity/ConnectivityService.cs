using System;
using System.Collections.Generic;

namespace Xamarin.Essentials
{
    public class ConnectivityService : IConnectivityService
    {
        public NetworkAccess NetworkAccess => Connectivity.NetworkAccess;

        public IEnumerable<ConnectionProfile> ConnectionProfiles => Connectivity.ConnectionProfiles;


        public event EventHandler<ConnectivityChangedEventArgs> ConnectivityChanged
        {
            add => Connectivity.ConnectivityChanged += value;
            remove => Connectivity.ConnectivityChanged -= value;        
        }
    }
}
