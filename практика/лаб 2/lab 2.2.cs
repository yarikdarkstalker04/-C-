using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string trbl="";
            int pred;
            Console.Write("Введите х:");
            int x = int.Parse(Console.ReadLine());
            if (x > 255 | x < 0)
            {
                trbl = "Ошибка: число х выходит из диапозона(0..255)";
            }
            else
            {
                pred = x;
                while (trbl == "")
                {
                    Console.Write("Введите х:");
                    x = int.Parse(Console.ReadLine());
                    if (x > 255 | x < 0)
                    {
                        trbl = "Ошибка: число х выходит из диапозона(0..255)";
                        break;
                    }
                    if (x - pred < 7)
                    {
                        trbl = "Ошибка: разность введенного числа и предыдущего меньше 7";
                        break;
                    }
                    pred = x;
                }
            }
            Console.Write(trbl);
            
            
            string wait = Console.ReadLine();
        }
        
    }
}
