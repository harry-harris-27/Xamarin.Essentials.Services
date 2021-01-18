using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class AppActionsService : IAppActionsService
    {
        public event EventHandler<AppActionEventArgs> OnAppAction
        {
            add => AppActions.OnAppAction += value;
            remove => AppActions.OnAppAction -= value;
        }

        public Task<IEnumerable<AppAction>> GetAsync() => AppActions.GetAsync();

        public Task SetAsync(params AppAction[] actions) => AppActions.SetAsync(actions);

        public Task SetAsync(IEnumerable<AppAction> actions) => AppActions.SetAsync(actions);
    }
}
