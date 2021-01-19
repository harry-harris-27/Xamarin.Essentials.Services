using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class PermissionsService : IPermissionsService
    {
        public virtual Task<PermissionStatus> CheckStatusAsync<TPermission>() where TPermission : Permissions.BasePermission, new()
            => Permissions.CheckStatusAsync<TPermission>();

        public virtual Task<PermissionStatus> RequestAsync<TPermission>() where TPermission : Permissions.BasePermission, new()
            => Permissions.RequestAsync<TPermission>();

        public virtual bool ShouldShowRationale<TPermission>() where TPermission : Permissions.BasePermission, new()
            => Permissions.ShouldShowRationale<TPermission>();
    }
}
