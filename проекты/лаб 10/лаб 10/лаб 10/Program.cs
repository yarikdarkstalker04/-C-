using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace лаб_10
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива:");
            int n = int.Parse(Console.ReadLine());
            Function[] arr = new Function[n];
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Какую функцию хотите добавить(0 - Линия, 1 - Куб, 2 - Гипербола)");
                
                while (true) {
                    int choose = int.Parse(Console.ReadLine());
                    if (choose == 0) {
                        Console.Write("Введите а:");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Введите b:");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Введите x:");
                        double x = double.Parse(Console.ReadLine());
                        arr[i] = new Line(a,b,x);
                        break;
                    }
                    else if (choose == 1) {
                        Console.Write("Введите а:");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Введите b:");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Введите c:");
                        double c = double.Parse(Console.ReadLine());
                        Console.Write("Введите x:");
                        double x = double.Parse(Console.ReadLine());
                        arr[i] = new Kub(a,b,c,x);
                        break;
                    }
                    else if (choose == 2)
                    {
                        Console.Write("Введите а:");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Введите x:");
                        double x = double.Parse(Console.ReadLine());
                        arr[i] = new Hyperbola(a,x);
                        break;
                    }
                    else {
                        Console.WriteLine("Введите целое число от 0 до 2!");
                    }
                }
               
            }
            Array.Sort(arr);
            foreach (Function elem in arr)
            {
                elem.formula();
                Console.Write(" ");
                elem.Print();
                
            }
            string wait = Console.ReadLine();
        }
    }
}
