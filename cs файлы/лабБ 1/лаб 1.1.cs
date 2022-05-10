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
            Console.WriteLine("введите первое число");
            string a = Console.ReadLine();
            Console.WriteLine("введите второе число");
            string b = Console.ReadLine();
            Console.WriteLine("{0}+{1}={1}+{0}", a, b);
            Console.WriteLine("Введите ENTER");
            string s = Console.ReadLine();
        }
    }
}
