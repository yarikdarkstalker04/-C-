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
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("h=");
            int h = int.Parse(Console.ReadLine());
            int i;
            Console.WriteLine("     x           f{x}");
            for (i = a; i < b + 1; i += h)
            {
                if (Math.Abs(i) < 3)
                {
                    Console.WriteLine("{0,14} {1,14}", i, Math.Sin(i));
                }
                else
                {
                    if (Math.Abs(i) >= 9)
                    {
                        Console.WriteLine("{0,14} {1,14}", i, Math.Sqrt(i * i + 1) - Math.Sqrt(i * i + 5));
                    }
                    else
                    {
                        Console.WriteLine("{0,14} {1,14}", i, Math.Sqrt(i * i + 1) / Math.Sqrt(i * i + 5));
                    }
                }
            }
            Console.WriteLine("Введите ENTER");
            string s = Console.ReadLine();
        }
    }
}
