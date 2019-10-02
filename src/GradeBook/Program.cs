using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 34.1;
            double y = 17.562;

            Console.WriteLine(x + y);

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
