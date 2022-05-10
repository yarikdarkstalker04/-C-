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
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y=");
            int y = int.Parse(Console.ReadLine());
            int i;
            int j;
            for (i = a; i < b + 1; i++)
            {
                if (Math.Abs(i % 10) == x || Math.Abs(i % 10) == y)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Введите ENTER");
            string s = Console.ReadLine();
        }
    }
}
