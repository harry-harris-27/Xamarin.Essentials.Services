using System;
using System.Threading;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class MainThreadService : IMainThreadService
    {
        public virtual bool IsMainThread => MainThread.IsMainThread;


        public virtual void BeginInvokeOnMainThread(Action action)
            => MainThread.BeginInvokeOnMainThread(action);

        public virtual Task<SynchronizationContext> GetMainThreadSynchronizationContextAsync()
            => MainThread.GetMainThreadSynchronizationContextAsync();

        public virtual Task InvokeOnMainThreadAsync(Action action)
            => MainThread.InvokeOnMainThreadAsync(action);

        public virtual Task<T> InvokeOnMainThreadAsync<T>(Func<T> func)
            => MainThread.InvokeOnMainThreadAsync(func);

        public virtual Task InvokeOnMainThreadAsync(Func<Task> funcTask)
            => MainThread.InvokeOnMainThreadAsync(funcTask);

        public virtual Task<T> InvokeOnMainThreadAsync<T>(Func<Task<T>> funcTask)
            => MainThread.InvokeOnMainThreadAsync(funcTask);
    }
}