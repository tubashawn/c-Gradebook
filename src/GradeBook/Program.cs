using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //  allows an array with an undefined number of indices
            // double[] numbers = new[] { 6.4, 5.34, 6.985, 5.2345, 777.89 };
            List<double> grades = new List<double>() { 6.4, 5.34, 6.985, 5.2345, 777.89 };
            grades.Add(56.1);
            

            double result = 0.0;
            foreach(double number in grades) {
                result += number;
            }

            double average = result / grades.Count;
            System.Console.WriteLine($"The sum of all grades is {result}");
            System.Console.WriteLine($"The average grade {average:N3}");


            if(args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
