using System;
using System.Text.RegularExpressions;
namespace UserRegistrationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Program");
            Console.WriteLine("Enter Email:");
            string userInput = Console.ReadLine();
            if (ValidateInput(userInput)) 
            {
                Console.WriteLine("given email is valid");
            }
            else
            {
                Console.WriteLine("given email is not  valid plz enter valid one");
            }
        

        }
        public  static bool ValidateInput(string userInput)
        {
            string email = "^[a-zA-Z0-9]*[._+-]?[a-zA-Z0-9]+@[0-9a-z]+.[a-z]+.?[a-z]+$";
            return Regex.IsMatch(userInput, email);



        }
    }
}
