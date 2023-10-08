namespace _10.MultiplyEvensbyOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
 Create a program that multiplies the sum of all even digits of a number by the sum
            of all odd digits of the same number:

 · Create a method called GetMultipleOfEvenAndOdds()

 · Create a method GetSumOfEvenDigits()

 · Create GetSumOfOddDigits()

 · You may need to use Math.Abs() for negative numbers
             */
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            int oddSum = 0;
            int evenSum = 0;
            OddOrEvenCheck(ref number, ref oddSum, ref evenSum);

            GetMultipleOfEvenAndOdds(oddSum, evenSum);
        }

        private static void GetMultipleOfEvenAndOdds(int oddSum, int evenSum)
        {
            Console.WriteLine(oddSum * evenSum);
        }

        private static void OddOrEvenCheck(ref int number, ref int oddSum, ref int evenSum)
        {
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                { evenSum += digit; }
                else if (digit % 2 == 1)
                { oddSum += digit; }
                number /= 10;
            }
        }



    }
    }
