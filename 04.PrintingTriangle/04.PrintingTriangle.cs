int input=int.Parse(Console.ReadLine());

static void PrintMethod(int row)
{
    for (int col = 1; col <= row; col++)
    { Console.Write(col + " "); }
    Console.WriteLine();
}

for (int row=1; row<=input; row++)
{
    PrintMethod(row);
}
for (int row=input-1; row>=1;row--)
{ PrintMethod(row); }