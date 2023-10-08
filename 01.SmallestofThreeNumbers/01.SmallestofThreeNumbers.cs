using System.ComponentModel;

namespace _01.SmallestofThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method that prints out the smallest of three integer numbers
            int first=int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int smallest = int.MaxValue;
            PrintTheSmallest(smallest,first,second,third);
        }

        private static void PrintTheSmallest(int first,int second,int third,int smallest)
        {
            if(first<smallest)
            { smallest = first; }
            if(second<smallest) 
            { smallest = second; }
            if (third<smallest)
            { smallest = third; }
            Console.WriteLine(smallest);
        }
    }
}