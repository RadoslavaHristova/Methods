namespace _03.CharactersinRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method that receives two characters and
            //prints all the characters between them according
            //to ASCII (on a single line).
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            //NOTE: If the second letter's ASCII value is less than
            //that of the first one, then the two initial letters should
            //be swapped
            CheckingTheBiggerChar(ref first, ref second);

            PrintChars(first, second);
        }

        private static void PrintChars(char first, char second)
        {
            for (int i = first + 1; i < second; i++)
            {
                Console.Write((char)i + " ");
            }
        }

        private static void CheckingTheBiggerChar(ref char first, ref char second)
        {
            if (second < first)
            {
                (first, second) = (second, first);
            }
        }
    }
}