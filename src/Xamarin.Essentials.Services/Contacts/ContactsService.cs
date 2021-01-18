using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Xamarin.Essentials
{
    public class ContactsService : IContactsService
    {
        public Task<IEnumerable<Contact>> GetAllAsync(CancellationToken cancellationToken = default)
            => Contacts.GetAllAsync(cancellationToken);

        public Task<Contact> PickContactAsync() => Contacts.PickContactAsync();
    }
}
