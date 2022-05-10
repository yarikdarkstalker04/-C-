using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x1=");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("y1=");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("x2=");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("y2=");
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2), 0.5));

            Console.WriteLine("Введите ENTER");
            string s = Console.ReadLine();
        }
    }
}
