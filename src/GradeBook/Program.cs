using System;
using System.Collections.Generic;

namespace GradeBook
{


    class Program
    {
        static void Main(string[] args)
        {

            var p = new Program();
            Program.Main(args);

            var book = new Book("Shawn's gradebook");
            book.AddGrade(89.1);
            book.AddGrade(90.5);

            var grades = new List<double> { 10.0, 11.1, 22.2, 54.3 };
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(double number in grades) {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            double average = result / grades.Count;
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The sum of all grades is {result}");
            Console.WriteLine($"The average grade {average:N3}");
        }
    }
}
