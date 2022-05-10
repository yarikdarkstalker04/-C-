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
            Console.WriteLine("m=");
            int m = int.Parse(Console.ReadLine());
            switch (m)
            {
                case 1:
                    Console.WriteLine("пики");
                    break;
                case 2:
                    Console.WriteLine("трефы");
                    break;
                case 3:
                    Console.WriteLine("бубны");
                    break;
                case 4:
                    Console.WriteLine("червы");
                    break;
                default:
                    Console.WriteLine("1<=m<=4");
                    break;
            }
            Console.WriteLine("Для завершения программы нажмите ENTER...");
            string wait = Console.ReadLine();
        }
    }
}
