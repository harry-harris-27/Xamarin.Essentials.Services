using System;

namespace Xamarin.Essentials
{
    public class PreferenceService : IPreferencesService
    {
        public virtual bool ContainsKey(string key) => Preferences.ContainsKey(key);
        public virtual bool ContainsKey(string key, string sharedName) => Preferences.ContainsKey(key, sharedName);

        public virtual void Remove(string key) => Preferences.Remove(key);
        public virtual void Remove(string key, string sharedName) => Preferences.Remove(key, sharedName);

        public virtual void Clear() => Preferences.Clear();
        public virtual void Clear(string sharedName) => Preferences.Clear(sharedName);

        public virtual string Get(string key, string defaultValue) => Preferences.Get(key, defaultValue);
        public virtual bool Get(string key, bool defaultValue) => Preferences.Get(key, defaultValue);
        public virtual int Get(string key, int defaultValue) => Preferences.Get(key, defaultValue);
        public virtual double Get(string key, double defaultValue) => Preferences.Get(key, defaultValue);
        public virtual float Get(string key, float defaultValue) => Preferences.Get(key, defaultValue);
        public virtual long Get(string key, long defaultValue) => Preferences.Get(key, defaultValue);
        public virtual DateTime Get(string key, DateTime defaultValue)=> Preferences.Get(key, defaultValue);

        public virtual void Set(string key, string value) => Preferences.Set(key, value);
        public virtual void Set(string key, bool value) => Preferences.Set(key, value);
        public virtual void Set(string key, int value) => Preferences.Set(key, value);
        public virtual void Set(string key, double value) => Preferences.Set(key, value);
        public virtual void Set(string key, float value) => Preferences.Set(key, value);
        public virtual void Set(string key, long value) => Preferences.Set(key, value);
        public virtual void Set(string key, DateTime value) => Preferences.Set(key, value);

        public virtual string Get(string key, string defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);
        public virtual bool Get(string key, bool defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);
        public virtual int Get(string key, int defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);
        public virtual double Get(string key, double defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);
        public virtual float Get(string key, float defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);
        public virtual long Get(string key, long defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);
        public virtual DateTime Get(string key, DateTime defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);

        public virtual void Set(string key, string value, string sharedName) => Preferences.Set(key, value, sharedName);
        public virtual void Set(string key, bool value, string sharedName) => Preferences.Set(key, value, sharedName);
        public virtual void Set(string key, int value, string sharedName) => Preferences.Set(key, value, sharedName);
        public virtual void Set(string key, double value, string sharedName) => Preferences.Set(key, value, sharedName);
        public virtual void Set(string key, float value, string sharedName) => Preferences.Set(key, value, sharedName);
        public virtual void Set(string key, long value, string sharedName) => Preferences.Set(key, value, sharedName);
        public virtual void Set(string key, DateTime value, string sharedName) => Preferences.Set(key, value, sharedName);
    }
}
