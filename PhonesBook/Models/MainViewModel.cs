using PhonesBook.Repositories;
using System.Diagnostics;

namespace PhonesBook.Models
{
    public class MainViewModel
    {
        private static MainViewModel viewModel;
        private static ContactsRepository contactsRepository = new ContactsRepository();
        public string message { get; set; } = "test";

        public static MainViewModel GetInstance()
        {
            if(viewModel == null)
            {
                viewModel = new MainViewModel();
            }

            return viewModel;
        }
        public List<Contact > GetContacts()
        {
            return contactsRepository.GetContacts();
        }
        public bool AddContact(Contact contact)
        {
            
            if (Contact.CheckName(contact.name) && Contact.CheckNumber(contact.number)){
                Debug.WriteLine("Data is correct");
                contact.id = contactsRepository.GetContactsCount();
                contactsRepository.AddContact(contact);
                return true;
            }
            return false;    
        }
        public void Remove(int id)
        {
            contactsRepository.RemoveContact(id);
        }
    }
}
