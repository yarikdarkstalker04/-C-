using System;

namespace ConsoleApp2
{
    class Lab_5_v2
    {
        public int[] arr;
        public Lab_5_v2(int[] a)
        {
            this.arr = a;
        }
        public Lab_5_v2()
        {
            this.arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                this.arr[i] = i;
            }
        }
        public static Lab_5_v2 operator +(Lab_5_v2 op1, Lab_5_v2 op2)
        {
            int[] largest = (op1.arr.Length > op2.arr.Length) ? op1.arr : op2.arr;
            int[] shortest = (op1.arr.Length > op2.arr.Length) ? op2.arr : op1.arr;
            if (op1.arr.Length > op2.arr.Length)
            {
                Lab_5_v2 r = new Lab_5_v2(largest);
                for (int i = 0; i < largest.Length; i++)
                {
                    if (i >= shortest.Length)
                    {
                        r.arr[i] = op1.arr[i];
                    }
                    else
                    {
                        r.arr[i] = op1.arr[i] + op2.arr[i];
                    }

                }
                return r;
            }
            else
            {
                Lab_5_v2 r = new Lab_5_v2(shortest);
                for (int i = 0; i < shortest.Length; i++)
                {
                    r.arr[i] = op1.arr[i] + op2.arr[i];
                }
                return r;
            }


        }
        public static Lab_5_v2 operator -(Lab_5_v2 op1, Lab_5_v2 op2)
        {
            int[] largest = (op1.arr.Length > op2.arr.Length) ? op1.arr : op2.arr;
            int[] shortest = (op1.arr.Length > op2.arr.Length) ? op2.arr : op1.arr;

            if (op1.arr.Length > op2.arr.Length)
            {
                Lab_5_v2 r = new Lab_5_v2(largest);
                for (int i = 0; i < largest.Length; i++)
                {
                    if (i >= shortest.Length)
                    {
                        r.arr[i] = op1.arr[i];
                    }
                    else
                    {
                        r.arr[i] = op1.arr[i] - op2.arr[i];
                    }
                }
                return r;
            }
            else
            {
                Lab_5_v2 r = new Lab_5_v2(shortest);
                for (int i = 0; i < shortest.Length; i++)
                {
                    r.arr[i] = op1.arr[i] - op2.arr[i];
                }
                return r;
            }

        }
        public void show()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Lab_5_v2 a = new Lab_5_v2();
            int[] array = { 0, 5, 68, 74, 45 };
            Lab_5_v2 b = new Lab_5_v2(array);
            Console.WriteLine("Массив а до вычитания:");
            a.show();
            Console.WriteLine();
            Console.WriteLine("Массив b до сложения:");
            b.show();
            Console.WriteLine();
            Console.WriteLine("Массив a после вычитания массива b:");
            a -= b;
            a.show();
            Console.WriteLine();
            Console.WriteLine("Массив b после сложения с массивом а:");
            b += a;
            b.show();
            string wait = Console.ReadLine();
        }

    }
}
