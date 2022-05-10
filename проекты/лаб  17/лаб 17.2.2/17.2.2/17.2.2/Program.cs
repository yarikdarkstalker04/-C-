using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + "/input.txt");
            Queue<string> queue = new Queue<string>();
            using (sr)
            {
                string word;
                while ((word = sr.ReadLine()) != null)
                { 
                    if (char.IsUpper(word[0]))
                    {
                        Console.WriteLine(word);
                    }
                    else
                    {
                        queue.Enqueue(word);
                    }
                }
            }
            int length = queue.Count;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.ReadKey();
        }
    }
}
