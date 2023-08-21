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
                Console.WriteLine("given passwordis number not  valid ,plz enter password of atleadt 8 chrachters and one UpperCase");
            }
        

        }
        public  static bool ValidateInput(string userInput)
        {
            string password = "^(?=.*[A-Z]).{8,}$";
            return Regex.IsMatch(userInput, password);



        }
    }
}
