namespace _05.AddandSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*You will receive 3 integers. Create a method that returns
             * the sum of the first two integers and another method
             * that subtracts the third integer from the result of the sum method.*/
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = SumFinding(first, second);
            SubstractFromSumAndPrint(third, sum);
        }

        private static void SubstractFromSumAndPrint(int third, int sum)
        {
            int output = sum - third;
            Console.WriteLine(output);
        }

        private static int SumFinding(int first, int second)
        {
            return first + second;
        }
    }
}