/*
 Create a method, which receives two numbers as parameters:
· The first number – the base
· The second number – the power
The method should return the base raised to the given power
 */

double firstNumber=double.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

double result =Math.Pow(firstNumber, secondNumber);
Console.WriteLine(result);
