using System;
using System.Text.RegularExpressions;
namespace UserRegistrationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Program");
            Console.WriteLine("Enter a passward:");
            string userInput = Console.ReadLine();
            if (ValidateInput(userInput)) 
            {
                Console.WriteLine("password is valid");
            }
            else
            {
                Console.WriteLine("given passwordis number not  valid ,plz enter valid one");
            }
        

        }
        public  static bool ValidateInput(string userInput)
        {
            string password = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%&*!+=%]).{8,}$";
            return Regex.IsMatch(userInput, password);



        }
    }
}
