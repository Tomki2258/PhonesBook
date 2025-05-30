using PhonesBook.Repositories;

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
    }
}
