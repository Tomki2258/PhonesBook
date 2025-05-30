using PhonesBook.Models;

namespace PhonesBook.Repositories
{
    public class ContactsRepository : IContactRepository
    {
        private List<Contact> contacts = new List<Contact>();

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
    }
}
