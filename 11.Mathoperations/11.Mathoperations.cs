namespace _11.Mathoperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //two numbers and an operator, calculates the result and returns it
            //The possible operators are: /, *, + and -

            int firstNumber=int.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            int secondNumber=int.Parse(Console.ReadLine());

            CalculatedResult(firstNumber,action,secondNumber);

        }

        private static void CalculatedResult(int firstNumber,string action,int secondNumber)
        {
            switch(action) 
            {
                case "/":
                    Console.WriteLine(firstNumber/secondNumber);
                    break;
                case "*":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case "-":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case "+":
                    Console.WriteLine(firstNumber + secondNumber);
                    break;
            }
        }
    }
}