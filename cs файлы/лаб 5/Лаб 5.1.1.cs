using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int[] input(int n) {
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i=0;i<a.Length;i++){
                a[i]=rnd.Next(101);
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] a = input(n);
            Console.Write("Значения массива -");
            foreach (int x in a)
            {
                Console.Write(" {0}",x);
            }
            Console.WriteLine();
            int maxN=a[0];
            int maxI=0;
            for (int i=1; i < a.Length; i++) { 
             if (maxN<a[i]){
                 maxN = a[i];
                 maxI = i;
             }
            }
            Console.WriteLine("Максимальное число - {0}\nИндекс максимального числа - {1}",maxN,maxI);
            Console.WriteLine("Нажмите ENTER...");
            string wait = Console.ReadLine();
        }
    }
}
