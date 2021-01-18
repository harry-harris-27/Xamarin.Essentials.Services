using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class PermissionsService : IPermissionsService
    {
        public Task<PermissionStatus> CheckStatusAsync<TPermission>() where TPermission : Permissions.BasePermission, new()
            => Permissions.CheckStatusAsync<TPermission>();

        public Task<PermissionStatus> RequestAsync<TPermission>() where TPermission : Permissions.BasePermission, new()
            => Permissions.RequestAsync<TPermission>();

        public bool ShouldShowRationale<TPermission>() where TPermission : Permissions.BasePermission, new()
            => Permissions.ShouldShowRationale<TPermission>();
    }
}
