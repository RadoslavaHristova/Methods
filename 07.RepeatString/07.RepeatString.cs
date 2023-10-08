/*
 Create a method that receives two parameters:
· A string
· A number n (integer) represents how many times the string will be repeated

The method should return a new string,
containing the initial one, repeated n times without space.
 */

string input = Console.ReadLine();
int repeats=int.Parse(Console.ReadLine());

Console.WriteLine(ReturningNewString(input,repeats));

string ReturningNewString(string input,int repeats)
{
    string result = "";
    for (int i=0;i<repeats; i++)
    {
        result += input;
    }
    return result;
}