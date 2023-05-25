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
    }
}
