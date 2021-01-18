using System;
using System.IO;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IFileSystemService
    {
        string CacheDirectory { get; }

        string AppDataDirectory { get; }

        Task<Stream> OpenAppPackageFileAsync(string filename);
    }
}
