using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class FilePickerService : IFilePickerService
    {
        public Task<FileResult> PickAsync(PickOptions options = null) => FilePicker.PickAsync(options);

        public Task<IEnumerable<FileResult>> PickMultipleAsync(PickOptions options = null) => FilePicker.PickMultipleAsync(options);
    }
}
