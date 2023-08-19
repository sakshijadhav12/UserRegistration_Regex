﻿using System;
using System.Text.RegularExpressions;
namespace UserRegistrationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Program");
            Console.WriteLine("Enter last Name:");
            string userInput = Console.ReadLine();
            if (ValidateInput(userInput)) 
            {
                Console.WriteLine("{0} is valid last name", userInput);
            }
            else
            {
                Console.WriteLine("{0} is not  valid last name plz enter valid one", userInput);
            }
        

        }
        public  static bool ValidateInput(string userInput)
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}$";
            return Regex.IsMatch(userInput, pattern);


        }
    }
}
