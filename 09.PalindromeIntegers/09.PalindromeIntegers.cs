namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads positive integers
            //until you receive the "END" command.
            //For each number, print whether the number is a palindrome or not.
            //A palindrome is a number that reads the same backward as forward,
            //such as 323 or 1001.
            
            string input = "";
            while((input=Console.ReadLine())!="END")
            {
                string check=input;
                string reversed = ReverseString(input);

                if (reversed ==check)
                { Console.WriteLine("true"); }
                else { Console.WriteLine("false"); }
            }

            static string ReverseString(string input)
            {
                return new string(input.Reverse().ToArray());
            }
        }
    }
}
