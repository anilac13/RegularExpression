using System;
namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            UserValidation validation = new UserValidation();
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            validation.ValidateFirstName(firstName);
        }
    }
}