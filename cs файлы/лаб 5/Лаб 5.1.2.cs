using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double[] input(int n)
        {
            double[] a = new double[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            double[] a = input(n);
            Console.Write("Значения массива -");
            foreach (double x in a)
            {
                Console.Write(" {0}", x);
            }
            Console.WriteLine();
            double maxN = a[0];
            int maxI = 0;
            double minN = a[0];
            int minI = 0;
            int countOfNull = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (maxN < a[i])
                {
                    maxN = a[i];
                    maxI = i;
                }
                if (minN > a[i])
                {
                    minN = a[i];
                    minI = i;
                }
                if (a[i] == 0)
                {
                    countOfNull++;
                }
            }
            double[] y = new double[n - countOfNull];
            Array.Sort(a);
            double chekNaPlzht = a[0];
            int ind = 0;
            while (chekNaPlzht < 0)
            {
                chekNaPlzht = a[ind];
                y[y.Length - ind - 1] = a[ind];
                ind++;
                if (ind == a.Length)
                {
                    ind--;
                    break;
                }
            }
            while (a[ind] == 0)
            {
                ind++;
                if (ind == a.Length)
                {
                    break;
                }

            }
            int ind1 = 0;
            while (ind < a.Length)
            {
                y[ind1] = a[ind];
                ind++;
                ind1++;
            }
            Console.Write("Массив Y -");
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write(" {0}", y[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Максимальное число массива Х - {0}\nИндекс максимального числа массива Х - {1}", maxN, maxI);
            Console.WriteLine("Минимальное число массива Х - {0}\nИндекс минимального числа массива Х - {1}", minN, minI);
            maxN = y[0];
            int maxI_new = 0;
            minN = y[0];
            int minI_new = 0;
            for (int i = 1; i < y.Length; i++)
            {
                if (maxN < y[i])
                {
                    maxN = y[i];
                    maxI_new = i;
                }
                if (minN > y[i])
                {
                    minN = y[i];
                    minI_new = i;
                }
            }
            if (maxI > maxI_new)
            {
                Console.WriteLine("Максимальное число массива X сместилось влево на {0} элементов)", maxI - maxI_new);
            }
            else if (maxI < maxI_new)
            {
                Console.WriteLine("Максимальное число массива X сместилось вправо на {0} элементо)", maxI_new - maxI);
            }
            else
            {
                Console.WriteLine("Максимальное число массива X не сместилось");
            }
            if (minI > minI_new)
            {
                Console.WriteLine("Минимальное число массива X сместилось влево на {0} элементов", minI - minI_new);
            }
            else if (minI < minI_new)
            {
                Console.WriteLine("Минимальное число массива X сместилось вправо на {0} элементов", minI_new - minI);
            }
            else
            {
                Console.WriteLine("Минимальное число массива X не сместилось");
            }
            Console.WriteLine("Нажмите ENTER...");
            string wait = Console.ReadLine();
        }
    }
}
