using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
namespace UserRegistrationProgram
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Program");
            {
                string[] validEmails = {
            "abc@yahoo.com",
            "abc-100@yahoo.com",
            "abc.100@yahoo.com",
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc.100@abc.com.au",
            "abc@1.com",
            "abc@gmail.com.com",
            "abc+100@gmail.com"
        };

                string[] invalidEmails = {
            "abc",
            "abc@.com.my",
            "abc123@gmail.a",
            "abc123@.com",
            "abc123@.com.com",
            ".abc@abc.com",
            "abc()*@gmail.com",
            "abc@%*.com",
            "abc..2002@gmail.com",
            "abc.@gmail.com",
            "abc@abc@gmail.com",
            "abc@gmail.com.1a",
            "abc@gmail.com.aa.au"
        };
                Console.WriteLine("Valid Emails:");
                foreach (string userInput in validEmails)
                {
                    if (ValidateInput(userInput))
                    {
                        Console.WriteLine($"- {userInput}");
                    }
                }
                Console.WriteLine("\nInvalid Emails:");
                foreach (string userInput in invalidEmails)
                {
                    if (!ValidateInput(userInput))
                    {
                        Console.WriteLine($"- {userInput}");
                    }
                }
            }
        }
        public static bool ValidateInput(string userInput)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (Regex.IsMatch(userInput, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

               

   