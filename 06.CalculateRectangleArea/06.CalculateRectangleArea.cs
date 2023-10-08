//Create a method that calculates and returns the area of a rectangle.
double height = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());

Console.WriteLine(AreaOfRectangle(height,width));

double AreaOfRectangle(double height,double width)
{
    return (height * width);
}