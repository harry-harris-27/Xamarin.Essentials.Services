using System;
using System.Collections.Generic;

namespace Xamarin.Essentials
{
    public interface IConnectivityService
    {
        NetworkAccess NetworkAccess { get; }

        IEnumerable<ConnectionProfile> ConnectionProfiles { get; }


        event EventHandler<ConnectivityChangedEventArgs> ConnectivityChanged;
    }
}
