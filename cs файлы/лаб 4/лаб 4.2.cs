using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double OSPD(double a)
        {
            double resultOfOSPD = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    resultOfOSPD += i;
                }
            }
            return resultOfOSPD;
        }

        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            if (x != 0)
            {
                string allTxt = "";
                while (x != 0)
                {
                    allTxt += x.ToString();
                    allTxt += " - ";
                    allTxt += OSPD(x);
                    allTxt += "\n";
                    x = double.Parse(Console.ReadLine());
                }
                allTxt = allTxt.Trim();
                Console.WriteLine(allTxt);
            }

            Console.WriteLine("Нажмите ENTER...");
            string wait = Console.ReadLine();
        }
    }
}
