namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method that receives a single string
            //and prints out the number of vowels contained in it.

            string input = Console.ReadLine();
            char[]inputNew=input.ToCharArray();
            int vowelsQty = 0;
            vowelsQty = CheckVowelsQty(inputNew, vowelsQty);
            Console.WriteLine(vowelsQty);
        }

        private static int CheckVowelsQty(char[] inputNew, int vowelsQty)
        {
            for (int i = 0; i < inputNew.Length; i++)
            {//a, e, i, o, u
                if (inputNew[i] == 'a' || inputNew[i] == 'A')
                { vowelsQty++; }
                else if (inputNew[i] == 'e' || inputNew[i] == 'E')
                { vowelsQty++; }
                else if (inputNew[i] == 'i' || inputNew[i] == 'I')
                { vowelsQty++; }
                else if (inputNew[i] == 'o' || inputNew[i] == 'O')
                { vowelsQty++; }
                else if (inputNew[i] == 'u' || inputNew[i] == 'U')
                { vowelsQty++; }
            }

            return vowelsQty;
        }
    }
}