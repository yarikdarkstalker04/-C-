using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double max(double a, double b) 
        {
            if (a > b)
            {
                return a;
            }
            else 
            {
                return b;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());
            double z = max(x, 2 * y - x) + max(5 * x + 3 * y, y);
            Console.WriteLine(z);
            Console.WriteLine("Нажмите любую клавишу...");
            string wait = Console.ReadLine();
        }
    }
}
