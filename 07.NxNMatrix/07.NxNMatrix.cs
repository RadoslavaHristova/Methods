namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method that receives a single integer n
            //and prints an NxN matrix using this number as a filler

            int input=int.Parse(Console.ReadLine());
            for(int row=1; row<=input; row++)
            {
                PrintMatrix(input);
            }

        }

        private static void PrintMatrix(int input)
        {
            for (int col = 1; col <= input; col++)
            { Console.Write(input + " "); }
            Console.WriteLine();
        }
    }
}