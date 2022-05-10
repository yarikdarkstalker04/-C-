using System;
using System.Text;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    s.Remove(i, 1);
                    i--;
                }
            }
            Console.WriteLine(s);
            string stt = Console.ReadLine();
        }

    }
}
