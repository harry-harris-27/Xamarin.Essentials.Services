using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class AppActionsService : IAppActionsService
    {
        public virtual event EventHandler<AppActionEventArgs> OnAppAction
        {
            add => AppActions.OnAppAction += value;
            remove => AppActions.OnAppAction -= value;
        }


        public virtual Task<IEnumerable<AppAction>> GetAsync() => AppActions.GetAsync();

        public virtual Task SetAsync(params AppAction[] actions) => AppActions.SetAsync(actions);

        public virtual Task SetAsync(IEnumerable<AppAction> actions) => AppActions.SetAsync(actions);
    }
}
