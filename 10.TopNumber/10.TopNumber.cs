namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            A top number is an integer that holds the following properties:

            Its sum of digits is divisible by 8, e.g. 8, 17, 88
            Holds at least one odd digit, e.g. 232, 707, 87578
            Some examples of top numbers are: 17, 161, 251, 4310, 123200
            Create a program to print all top numbers in the range [1…n].
            You will receive a single integer from the console,
            representing the end value.
            */

            int endValue=int.Parse(Console.ReadLine());
            
            for(int i=1; i<endValue; i++) 
            {
                if (IsTopNumber(i))
                { Console.WriteLine(i); }
            }
        }

        static bool IsDivisibleByEight(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10; // Get the last digit
                num /= 10; // Remove the last digit   
                sum += digit;
            }

            return sum % 8 == 0;
        }
        private static bool IsTopNumber(int num)
        {
            if(IsDivisibleByEight(num)&&CheckForOddNumber(num))
            { return true; }
            return false;
        }

        static bool CheckForOddNumber(int endNumber)
        {
            while (endNumber > 0)
            {
                int digit = endNumber % 10;
                if (digit % 2 != 0)
                { return true; }
                endNumber /= 10;
            }
            return false; }
        }

    
        }
    
