using System;

namespace Xamarin.Essentials
{
    public class PreferenceService : IPreferencesService
    {
        public bool ContainsKey(string key) => Preferences.ContainsKey(key);
        public bool ContainsKey(string key, string sharedName) => Preferences.ContainsKey(key, sharedName);

        public void Remove(string key) => Preferences.Remove(key);
        public void Remove(string key, string sharedName) => Preferences.Remove(key, sharedName);

        public void Clear() => Preferences.Clear();
        public void Clear(string sharedName) => Preferences.Clear(sharedName);

        public string Get(string key, string defaultValue) => Preferences.Get(key, defaultValue);
        public bool Get(string key, bool defaultValue) => Preferences.Get(key, defaultValue);
        public int Get(string key, int defaultValue) => Preferences.Get(key, defaultValue);
        public double Get(string key, double defaultValue) => Preferences.Get(key, defaultValue);
        public float Get(string key, float defaultValue) => Preferences.Get(key, defaultValue);
        public long Get(string key, long defaultValue) => Preferences.Get(key, defaultValue);
        public DateTime Get(string key, DateTime defaultValue)=> Preferences.Get(key, defaultValue);

        public void Set(string key, string value) => Preferences.Set(key, value);
        public void Set(string key, bool value) => Preferences.Set(key, value);
        public void Set(string key, int value) => Preferences.Set(key, value);
        public void Set(string key, double value) => Preferences.Set(key, value);
        public void Set(string key, float value) => Preferences.Set(key, value);
        public void Set(string key, long value) => Preferences.Set(key, value);
        public void Set(string key, DateTime value) => Preferences.Set(key, value);

        public string Get(string key, string defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);
        public bool Get(string key, bool defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);
        public int Get(string key, int defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);
        public double Get(string key, double defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);
        public float Get(string key, float defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);
        public long Get(string key, long defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);
        public DateTime Get(string key, DateTime defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);

        public void Set(string key, string value, string sharedName) => Preferences.Set(key, value, sharedName);
        public void Set(string key, bool value, string sharedName) => Preferences.Set(key, value, sharedName);
        public void Set(string key, int value, string sharedName) => Preferences.Set(key, value, sharedName);
        public void Set(string key, double value, string sharedName) => Preferences.Set(key, value, sharedName);
        public void Set(string key, float value, string sharedName) => Preferences.Set(key, value, sharedName);
        public void Set(string key, long value, string sharedName) => Preferences.Set(key, value, sharedName);
        public void Set(string key, DateTime value, string sharedName) => Preferences.Set(key, value, sharedName);
    }
}
