using System;
using System.Collections.Generic;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку: ");
            string input2 = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            if (input1.Length != input2.Length)
            {
                Console.WriteLine("Не являются обратными");
            }
            else
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    stack.Push(input1[i]);
                }
                bool passed = true;
                for (int i = 0; i < input1.Length; i++)
                {
                    if (stack.Pop() != input2[i])
                    {
                        passed = false;
                        break;
                    }
                }
                if (passed)
                {
                    Console.WriteLine("Являются обратными ");
                }
                else
                {
                    Console.WriteLine("Не являются обратными ");
                }
            }
            Console.ReadKey();
        }
    }
}
