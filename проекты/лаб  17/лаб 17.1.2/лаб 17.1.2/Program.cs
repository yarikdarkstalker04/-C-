using System;
using System.Collections.Generic;
using System.IO;

namespace z1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(Environment.CurrentDirectory + "/input.txt");
            string line = sr.ReadLine();
            string[] values = line.Split(new char[] { ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(values);
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < values.Length; i++)
            {
                int num;
                if (int.TryParse(values[i], out num))
                {
                    stack.Push(num);
                } 
                else
                {
                    if (values[i] == "m")
                    {
                        stack.Push(Math.Min(stack.Pop(), stack.Pop()));
                    }
                    else if (values[i] == "M")
                    {
                        stack.Push(Math.Max(stack.Pop(), stack.Pop()));
                    }
                }
            }
            Console.WriteLine(stack.Pop());
            Console.ReadLine();
        }
    }
}

