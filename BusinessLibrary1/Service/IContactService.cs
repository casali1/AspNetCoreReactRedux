using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLibrary.Service
{
    public interface IContactService
    {
        Task<List<ContactModel>> GetContacts();
        Task<bool> SaveContact(ContactModel contact);
        Task<bool> DeleteContact(int contactId);
    }
}
