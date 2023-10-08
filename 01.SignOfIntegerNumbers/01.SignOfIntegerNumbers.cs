//Input
//A single integer is given
int input =int.Parse(Console.ReadLine());
//checks if the given number is positive, negative, or zero
PositiveNumber( input);
NegativeNumber(input);
ZeroNumber(input);
//Print
/*
 · For positive number: "The number {number} is positive. "

· For negative number: "The number {number} is negative. "

· For zero number: "The number {number} is zero. "
 */
void ZeroNumber(int input)
{
    if (input == 0)
    { Console.WriteLine($"The number {input} is zero."); }
}

void NegativeNumber(int input)
{
    if (input < 0) { Console.WriteLine($"The number {input} is negative."); }
}

void PositiveNumber(int input)
{
    if(input>0) { Console.WriteLine($"The number {input} is positive."); }
}
