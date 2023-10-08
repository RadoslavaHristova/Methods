double grade = double.Parse(Console.ReadLine());
GradeCheck(grade);

void GradeCheck(double grade)
{
    if(grade >=2.00&& grade<=2.99 )
    { Console.WriteLine("Fail"); }
    else if (grade >= 3.00 && grade <= 3.49)//3.00 – 3.49 - "Poor"
    { Console.WriteLine("Poor"); }
    else if (grade >= 3.50 && grade <= 4.49)//3.50 – 4.49 - "Good"
    { Console.WriteLine("Good"); }
    else if (grade >= 4.40 && grade <= 5.49)// 4.50 – 5.49 - "Very good"
    { Console.WriteLine("Very good"); }
    else if (grade >= 5.50 && grade <= 6.00)//5.50 – 6.00 - "Excellent
    { Console.WriteLine("Excellent"); }
}

/*
Create a method that receives a grade between 2.00 and 6.00
and prints the corresponding grade definition:

· 2.00 – 2.99 - "Fail"

· 3.00 – 3.49 - "Poor"

· 3.50 – 4.49 - "Good"

· 4.50 – 5.49 - "Very good"

· 5.50 – 6.00 - "Excellent
 */