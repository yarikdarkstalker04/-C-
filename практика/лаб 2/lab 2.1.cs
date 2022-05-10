using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x:");
            int x = int.Parse(Console.ReadLine());
            if (x > 255)
            {
                Console.WriteLine("Квадратный корень числа х: {0}", Math.Sqrt(x));
            }
            else {
                if (x >= 0)
                {
                    Console.WriteLine("Символ - {0}, код символа - {1}", Convert.ToChar(x), x);
                }
                else {
                    Console.WriteLine("Данному коду({0}) нет соответствующего символа", x);
                }
            }
            string wait = Console.ReadLine();
        }
        
    }
}
