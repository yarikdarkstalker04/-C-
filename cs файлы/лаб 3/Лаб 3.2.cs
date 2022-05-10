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
            int i;
            int j;
            for (i = 1; i < 11; i++)
            {
                for (j = 1; j < 11; j++)
                {
                    Console.Write(" {0 }", j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите ENTER");
            string s = Console.ReadLine();
        }
    }
}
