using PhonesBook.Repositories;

namespace PhonesBook.Models
{
    public class CreateViewModel
    {
        private readonly ContactsRepository contactsRepository = ContactsRepository.GetInstance();
        
        public Contact contact { get; set; } = new Contact();
    }
}
