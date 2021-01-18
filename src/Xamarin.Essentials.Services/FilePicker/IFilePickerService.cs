using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IFilePickerService
    {
        Task<FileResult> PickAsync(PickOptions options = null);

        Task<IEnumerable<FileResult>> PickMultipleAsync(PickOptions options = null);
    }
}
