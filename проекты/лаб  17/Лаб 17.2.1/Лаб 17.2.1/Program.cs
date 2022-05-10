using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Console.WriteLine("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + "/input.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    int num = int.Parse(line);
                    if (num >= a && num <= b)
                    {
                        Console.Write("{0} ", num);
                    }
                    else
                    {
                        queue.Enqueue(num);
                    }
                }

            }
            int length = queue.Count;
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ",queue.Dequeue());
            }
            Console.ReadKey();
        }
    }
}
    