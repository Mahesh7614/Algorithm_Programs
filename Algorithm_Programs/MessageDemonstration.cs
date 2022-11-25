
using System.Text.RegularExpressions;

namespace Algorithm_Programs
{
    public class MessageDemonstration
    {
        public string FirstNameAndLastName(string Name)
        {
            Regex firstLastName = new Regex(@"^([A-Z]{1}[a-z]{2,})$");
            bool matches = firstLastName.IsMatch(Name);
            if (matches == true)
            {
                return Name;
            }
            else
            {
                Console.WriteLine($"Please Enter Valid Name {Name}");
                return " ";
            }
        }
        public string MobileNumber(string mobileNumber)
        {

            Regex number = new Regex(@"^*[1-9]{1,3}[-][1-9]{1}[0-9]{9}$");
            bool matches = number.IsMatch(mobileNumber);
            if (matches == true)
            {
                return mobileNumber;
            }
            else
            {
                Console.WriteLine($"Please Enter Valid Mobile Number {mobileNumber}");
                return " ";
            }
        }
        public string Date(string date)
        {
            Regex number = new Regex(@"^(([012]\d)|3[01])/((0\d)|(1[012]))/\d{4}$");
            bool matches = number.IsMatch(date);
            if (matches == true)
            {
                return date;
            }
            else
            {
                Console.WriteLine($"Please Enter Valid Date {date}");
                return " ";
            }
        }
    }
}
