using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double[,] input(int n)
        {
            Random rnd = new Random();
            double[,] a = new double[n, n];
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    a[i, j] = rnd.Next(101);
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            double[,] a = input(n);
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Отзеркаленая по главной диагонали матрица:");
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = i; j <= n - 1; j++)
                {
                    double buf = a[i, j];
                    a[i, j] = a[j, i];
                    a[j, i] = buf;
                }

            }
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите ENTER...");
            string wait = Console.ReadLine();
        }
    }
}
