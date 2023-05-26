using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class UserValidation
    {
        public const string NAME = @"^[A-Z][a-z]{2,}$";
        public const string EMAIL = @"^[a-zA-z0-9.+-]+[@]+[a-zA-z0-9]+[.]+[a-zA-z0-9.]{2,}$";
        public void ValidateFirstName(string firstName)
        {
            Regex obj = new Regex(NAME);
            if (obj.IsMatch(firstName))
            {
                Console.WriteLine("Valid first name");
            }
            else
            {
                Console.WriteLine("Invalid first name");
            }
        }
        public void ValidateLastName(string lastName)
        {
            Regex obj = new Regex(NAME);
            if (obj.IsMatch(lastName))
            {
                Console.WriteLine("Valid last name");
            }
            else
            {
                Console.WriteLine("Invalid last name");
            }
        }
        public void ValidateEmail(string email)
        {
            Regex obj = new Regex(EMAIL);
            if (obj.IsMatch(email))
            {
                Console.WriteLine("Valid E-Mail");
            }
            else
            {
                Console.WriteLine("Invalid E-Mail");
            }
        }
    }
}
