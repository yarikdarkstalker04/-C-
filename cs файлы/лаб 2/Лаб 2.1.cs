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
            Console.Write("х=");
            double x = double.Parse(Console.ReadLine());
            if (x != 1 && x != -1)
            {
                double y = 1 / (Math.Pow(x, 2) - 1);
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine("Функция не имеет значений");
            }
            Console.WriteLine("Для завершения программы нажмите ENTER...");
            string wait = Console.ReadLine();
        }
    }
}
