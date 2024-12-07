using System;

namespace studentgradingsystem
{

        class Gradingsystem
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter ICT marks: ");
        int ictMarks = int.Parse(Console.ReadLine()); 

        Console.WriteLine("Enter BCOM marks: ");
        int bcomMarks = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter ECON marks: ");
        int econMarks = int.Parse(Console.ReadLine());

        // Calculate the average percentage
        double averagePercentage = (ictMarks + bcomMarks + econMarks) / 3.0;

        string grade;

        // Determine the grade using a switch-case statement
        switch (averagePercentage)
        {
            case >= 75:
                grade = "Distinction";
                break;
            case >= 60:
                grade = "First class";
                break;
            case >= 50:
                grade = "Second class";
                break;
            case >= 40:
                grade = "Pass class";
                break;
            default:
                grade = "Fail";
                break;
        }

        Console.WriteLine($"The average percentage is: {averagePercentage:F2}");
        Console.WriteLine($"The grade is: {grade}");
    }
}
}