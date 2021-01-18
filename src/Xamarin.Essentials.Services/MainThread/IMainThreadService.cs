using System;
using System.Threading;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IMainThreadService
    {
        bool IsMainThread { get; }

        void BeginInvokeOnMainThread(Action action);

        Task InvokeOnMainThreadAsync(Action action);

        Task<T> InvokeOnMainThreadAsync<T>(Func<T> func);

        Task InvokeOnMainThreadAsync(Func<Task> funcTask);

        Task<T> InvokeOnMainThreadAsync<T>(Func<Task<T>> funcTask);

        Task<SynchronizationContext> GetMainThreadSynchronizationContextAsync();
    }
}
