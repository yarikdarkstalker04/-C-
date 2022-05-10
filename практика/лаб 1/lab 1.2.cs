using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());
            Console.Write("z=");
            double z = double.Parse(Console.ReadLine());
            double a = (3 + Math.E) / (1 + x * x);
            double b = 1 + x * x * x + (Math.Pow(Math.Abs(y - x), 3) / 3);
            Console.WriteLine("a = {0,5:N}",a);
            Console.WriteLine("b = {0,5:N}",b);
            string wait = Console.ReadLine();
        }
        
    }
}
