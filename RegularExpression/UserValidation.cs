﻿using System;
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
        public const string EMAIL = @"^[a-zA-z0-9.+-]+[@][a-zA-z0-9]+[.][a-zA-z0-9.]{2,}$";
        public const string NUMBER = @"^[91 ]+[6-9][0-9]{9}$";
        public const string PASSWORD = @"^[A-Z]{1,}[a-zA-Z0-9]{0,}[0-9]{1,}[@#$%&*!]{1,}[a-zA-Z0-9]+$";
        public void ValidateFirstName(string firstName)
        {
            Regex obj = new Regex(NAME);
            try
            {
                if (obj.IsMatch(firstName))
                {
                    Console.WriteLine("Valid first name");
                }
                else
                {
                    Console.WriteLine("Invalid first name");
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void ValidateLastName(string lastName)
        {
            Regex obj = new Regex(NAME);
            try
            {
                if (obj.IsMatch(lastName))
                {
                    Console.WriteLine("Valid last name");
                }
                else
                {
                    Console.WriteLine("Invalid last name");
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void ValidateEmail(string email)
        {
            Regex obj = new Regex(EMAIL);
            try
            {
                if (obj.IsMatch(email))
                {
                    Console.WriteLine("Valid E-Mail");
                }
                else
                {
                    Console.WriteLine("Invalid E-Mail");
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void ValidatePhoneNumber(string number)
        {
            Regex obj = new Regex(NUMBER);
            try
            {
                if (obj.IsMatch(number))
                {
                    Console.WriteLine("Valid Phone number");
                }
                else
                {
                    Console.WriteLine("Invalid Phone number");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ValidatePassword(string password)
        {
            Regex obj = new Regex(PASSWORD);
            try
            {
                if (obj.IsMatch(password))
                {
                    Console.WriteLine("Valid Password");
                }
                else
                {
                    Console.WriteLine("Invalid Password");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ValidateAllMails()
        {
            string[] emails = { "abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net","abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc+100@gmail.com",
            "abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com", "abc@%*.com","abc..2002@gmail.com", "abc.@gmail.com","abc@abc@gmail.com", "abc@gmail.com.1a","abc@gmail.com.aa.au"};
            foreach (string email in emails)
            {
                Regex obj = new Regex (EMAIL);
                try
                {
                    if (obj.IsMatch(email))
                    {
                        Console.WriteLine("Valid E-Mail");
                    }
                    else
                    {
                        Console.WriteLine("Invalid E-Mail");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
