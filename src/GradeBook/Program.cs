using System;
using System.Collections.Generic;

namespace GradeBook
{


    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();

            book.AddGrade(89.1);

            var grades = new List<double> { 10.0, 11.1, 22.2, 54.3 };
            var result = 0.0;
            foreach(double number in grades) {
                result += number;
            }

            double average = result / grades.Count;
            Console.WriteLine($"The sum of all grades is {result}");
            Console.WriteLine($"The average grade {average:N3}");
        }
    }
}
