//Input
/*
· On the first line – a string – "add", "multiply", "subtract", "divide".

· On the second line – a number.

· On the third line – another number.
 */
string action = Console.ReadLine();
int firstNum=int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
switch (action)
{
    case
    "add":AdditionOfTwoNumbers(firstNum,secondNum);
        break;
    case
    "multiply":MultiplyingTwoNumbers(firstNum, secondNum);
        break;
    case
    "subtract":SubstractingTwoNumbers(firstNum, secondNum);
        break;
    case
    "divide":DividingTwoNumbers(firstNum, secondNum);
        break;
}

void DividingTwoNumbers(int first,int second)
{
    Console.WriteLine(firstNum / secondNum);
}

void SubstractingTwoNumbers(int first,int second)
{
    Console.WriteLine(firstNum - secondNum);
}

void MultiplyingTwoNumbers(int first,int second)
{
    Console.WriteLine(firstNum * secondNum);
}

void AdditionOfTwoNumbers(int first,int second)
{
    Console.WriteLine(firstNum+secondNum);
}
//create four methods (for each calculation)
//The method should also print the result (needs to be void).