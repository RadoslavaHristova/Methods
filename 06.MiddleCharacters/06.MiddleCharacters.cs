namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will receive a single string.
            //Create a method that prints the character found at its middle.
            //If the length of the string is even, there are two middle characters.
            string input =Console.ReadLine();

            PrintMiddleCharacter(input);
        }

         static void PrintMiddleCharacter(string input)
        {
            int length = input.Length;

            if (length % 2 == 1)
            {
                // If the string length is odd, print the single middle character
                int middleIndex = length / 2;
                Console.WriteLine($"{(char)input[middleIndex]}");
            }
            else
            {
                // If the string length is even, print both middle characters
                int middleIndex1 = (length / 2) - 1;
                int middleIndex2 = length / 2;
                Console.WriteLine($"{(char)input[middleIndex1]}{(char)input[middleIndex2]}");
            }
        }

       
    }
    }
