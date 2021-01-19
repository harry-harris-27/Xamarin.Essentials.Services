using System;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class SecureStorageService : ISecureStorageService
    {
        public virtual Task<string> GetAsync(string key) => SecureStorage.GetAsync(key);

        public virtual bool Remove(string key) => SecureStorage.Remove(key);

        public virtual void RemoveAll() => SecureStorage.RemoveAll();

        public virtual Task SetAsync(string key, string value) => SecureStorage.SetAsync(key, value);
    }
}
