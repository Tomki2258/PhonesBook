using PhonesBook.Models;

namespace PhonesBook.Repositories
{
    public class ContactsRepository : IContactRepository
    {
        private List<Contact> contacts = new List<Contact>();
        private static ContactsRepository contactsRepository;

        public static ContactsRepository GetInstance()
        {
            if(contactsRepository == null)
            {
                contactsRepository = new ContactsRepository();
            }
            return contactsRepository;
        }
        public ContactsRepository()
        {
            var contact = new Contact();
            contact.name = "Stefan";
            contact.number = 123456789;
            contacts.Add(contact);
        }
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public List<Contact> GetContacts()
        {
            return contacts;
        }
        public int GetContactsCount()
        {
            return contacts.Count;
        }
        public void RemoveContact(int id)
        {
            contacts.RemoveAt(id);
        }
        public void ReplaceContact(int id,Contact contact)
        {
            contacts.RemoveAt(id);
            contacts.Add(contact);
        }
    }
}
