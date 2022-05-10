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
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());
            if (y >= 0)
            {
                if (Math.Abs(x) + Math.Abs(y) < 2)
                {
                    if (x + y == 0)
                    {
                        Console.WriteLine("На границе");
                    }
                    else
                    {
                        Console.WriteLine("Да");
                    }
                }
                else
                {
                    if (Math.Abs(x) + Math.Abs(y) > 2)
                    {
                        Console.WriteLine("Нет");
                    }
                    else
                    {
                        Console.WriteLine("на границе");
                    }
                }
            }
            else
            {

                Console.WriteLine("Нет");

            }
            Console.WriteLine("Для завершения программы нажмите ENTER...");
            string wait = Console.ReadLine();
        }
    }
}
