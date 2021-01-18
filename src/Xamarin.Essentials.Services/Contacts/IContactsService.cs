using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public interface IContactsService
    {
        Task<Contact> PickContactAsync();

        Task<IEnumerable<Contact>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
