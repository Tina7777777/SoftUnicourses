using System;

namespace _04PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            PasswordValidity(password);
        }

        static void PasswordValidity(string password)
        {
            bool isInLengthRange = password.Length >= 6 && password.Length <= 10;
            bool isValidSymbols = true;
            bool containsTwoDigits = true;
            int digitCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    isValidSymbols = false;
                }

                if (char.IsDigit(password[i]))
                {
                    digitCounter++; 
                    
                }               
            }
            if (digitCounter < 2)
            {
                containsTwoDigits = false;
            }

            //            • "Password must be between 6 and 10 characters"
            //• "Password must consist only of letters and digits"
            //• "Password must have at least 2 digits"

            if (!isInLengthRange)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isValidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!containsTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isInLengthRange&&isValidSymbols&&containsTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
