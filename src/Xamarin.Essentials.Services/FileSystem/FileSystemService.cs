using System;
using System.IO;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class FileSystemService : IFileSystemService
    {
        public virtual string CacheDirectory => FileSystem.CacheDirectory;

        public virtual string AppDataDirectory => FileSystem.AppDataDirectory;

        public virtual Task<Stream> OpenAppPackageFileAsync(string filename) => FileSystem.OpenAppPackageFileAsync(filename);
    }
}
