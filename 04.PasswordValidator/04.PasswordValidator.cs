namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
         Create a program that checks if a given password is valid.       
            */

            string inputPassword = Console.ReadLine();
            bool isValid = true;

            //It should contain 6 – 10 characters (inclusive)
            //"Password must be between 6 and 10 characters"
            if (inputPassword.Length < 6 || inputPassword.Length > 10)
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            // It should contain only letters and digits
            //"Password must consist only of letters and digits"
            if (!IsAllLettersOrDigits(inputPassword))
            { Console.WriteLine("Password must consist only of letters and digits"); }

            //It should contain at least 2 digits
            //"Password must have at least 2 digits"
            if (!CheckForTwoDigits(inputPassword))
            { Console.WriteLine("Password must have at least 2 digits"); }

            if (isValid == true && CheckForTwoDigits(inputPassword) && IsAllLettersOrDigits(inputPassword))
            { Console.WriteLine("Password is valid"); }


            static bool IsAllLettersOrDigits(string inputPass)
            {
                foreach (char c in inputPass)
                {
                    if (!Char.IsLetterOrDigit(c))
                        return false;
                }
                return true;
            }
        }

        static bool CheckForTwoDigits(string inputPass)
        {
            int minimumNumberCount = 2; // Minimum number of digits required
            int numberCount = 0;

            foreach (char c in inputPass)
            {
                if (char.IsDigit(c))
                {
                    numberCount++;
                    if (numberCount >= minimumNumberCount)
                    {
                        return true; // Return true if at least 2 numbers are found
                    }
                }
            }

            return false; // Return false if less than 2 numbers are found
        }
    }
}
