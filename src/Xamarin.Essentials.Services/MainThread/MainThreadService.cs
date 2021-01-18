using System;
using System.Threading;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class MainThreadService : IMainThreadService
    {
        public bool IsMainThread => MainThread.IsMainThread;


        public void BeginInvokeOnMainThread(Action action)
            => MainThread.BeginInvokeOnMainThread(action);

        public Task<SynchronizationContext> GetMainThreadSynchronizationContextAsync()
            => MainThread.GetMainThreadSynchronizationContextAsync();

        public Task InvokeOnMainThreadAsync(Action action)
            => MainThread.InvokeOnMainThreadAsync(action);

        public Task<T> InvokeOnMainThreadAsync<T>(Func<T> func)
            => MainThread.InvokeOnMainThreadAsync(func);

        public Task InvokeOnMainThreadAsync(Func<Task> funcTask)
            => MainThread.InvokeOnMainThreadAsync(funcTask);

        public Task<T> InvokeOnMainThreadAsync<T>(Func<Task<T>> funcTask)
            => MainThread.InvokeOnMainThreadAsync(funcTask);
    }
}