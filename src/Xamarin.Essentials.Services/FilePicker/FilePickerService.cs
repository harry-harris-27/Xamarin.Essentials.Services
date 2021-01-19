using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class FilePickerService : IFilePickerService
    {
        public virtual Task<FileResult> PickAsync(PickOptions options = null) => FilePicker.PickAsync(options);

        public virtual Task<IEnumerable<FileResult>> PickMultipleAsync(PickOptions options = null) => FilePicker.PickMultipleAsync(options);
    }
}
