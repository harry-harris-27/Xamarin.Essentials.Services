using System;
using System.IO;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class FileSystemService : IFileSystemService
    {
        public string CacheDirectory => FileSystem.CacheDirectory;

        public string AppDataDirectory => FileSystem.AppDataDirectory;

        public Task<Stream> OpenAppPackageFileAsync(string filename) => FileSystem.OpenAppPackageFileAsync(filename);
    }
}
