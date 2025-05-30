using PhonesBook.Models;

namespace PhonesBook.Fabrics
{
    public static class ContactFabric
    {
        public static bool CheckContact(Contact contact)
        {
            if(CheckName(contact.name) && CheckNumber(contact.number))
            {
                return true;
            }
            return false;
        }
        private static bool CheckName(string name)
        {
            return name != null && name.Length < 15;
        }
        private static bool CheckNumber(int number)
        {
            var numberString = number.ToString();

            return numberString.Length == 9;
        }
    }
}
