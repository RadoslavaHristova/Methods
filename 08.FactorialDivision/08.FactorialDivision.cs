using System.Collections.Generic;

namespace _08.FactorialDivision
{
     class Program
    {
        static void Main(string[] args)
        {
            //Read two long -s.
            //Calculate the factorial of each number.
            //Divide the first result by the second and
            //print the result of the division
            //formatted to the second decimal point.

            long first = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());

           
            double devided = Factorial(first) / Factorial(second);
            Console.WriteLine($"{devided:F2}");
        }

         static double Factorial(long number)
        {
            long result = number;
            for (long i = number - 1; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}