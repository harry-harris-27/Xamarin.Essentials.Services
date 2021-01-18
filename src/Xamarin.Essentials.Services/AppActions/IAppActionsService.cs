using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IAppActionsService
    {

        event EventHandler<AppActionEventArgs> OnAppAction;


        Task<IEnumerable<AppAction>> GetAsync();

        Task SetAsync(params AppAction[] actions);

        Task SetAsync(IEnumerable<AppAction> actions);
        
    }
}
