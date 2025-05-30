namespace PhonesBook.Models
{
    public class Contact
    {
        public int id { get; set; }
        public string name { get; set; }
        public int number { get; set; }

        public static bool CheckName(string name)
        {
            return name != null && name.Length < 15;
        }
        public static bool CheckNumber(int number)
        {
            var numberString = number.ToString();

            return numberString.Length == 9;
        }
    }
}
