using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IPermissionsService
    {
        Task<PermissionStatus> CheckStatusAsync<TPermission>() where TPermission : Permissions.BasePermission, new();

        Task<PermissionStatus> RequestAsync<TPermission>() where TPermission : Permissions.BasePermission, new();

        bool ShouldShowRationale<TPermission>() where TPermission : Permissions.BasePermission, new();
    }
}
