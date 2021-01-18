using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class SecureStorageService : ISecureStorageService
    {
        public Task<string> GetAsync(string key) => SecureStorage.GetAsync(key);

        public bool Remove(string key) => SecureStorage.Remove(key);

        public void RemoveAll() => SecureStorage.RemoveAll();

        public Task SetAsync(string key, string value) => SecureStorage.SetAsync(key, value);
    }
}
