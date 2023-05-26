using System;
namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            UserValidation validation = new UserValidation();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Validate First name \n2.Validate Last name \n3.Validate E-Mail \n4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter first name");
                        string firstName = Console.ReadLine();
                        validation.ValidateFirstName(firstName);
                        break;
                    case 2:
                        Console.WriteLine("Enter last name");
                        string lastName = Console.ReadLine();
                        validation.ValidateFirstName(lastName);
                        break;
                    case 3:
                        Console.WriteLine("Enter E-Mail");
                        string email = Console.ReadLine();
                        validation.ValidateEmail(email);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
            
        }
    }
}