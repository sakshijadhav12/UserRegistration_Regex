using System;
using System.Text.RegularExpressions;
namespace UserRegistrationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Program");
            Console.WriteLine("Enter phone number:");
            string userInput = Console.ReadLine();
            if (ValidateInput(userInput)) 
            {
                Console.WriteLine("given phone number is valid");
            }
            else
            {
                Console.WriteLine("given pone number is not  valid plz enter valid one");
            }
        

        }
        public  static bool ValidateInput(string userInput)
        {
            string number = @"^91 \d{10}$";
            return Regex.IsMatch(userInput, number);



        }
    }
}
