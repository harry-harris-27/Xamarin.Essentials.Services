using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface ISecureStorageService
    {
        Task<string> GetAsync(string key);

        Task SetAsync(string key, string value);

        bool Remove(string key);

        void RemoveAll();
    }
}
