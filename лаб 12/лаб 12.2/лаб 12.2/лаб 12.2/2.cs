using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); 
            int notbyte = rnd.Next(256, 2147483647); 
            byte sh; 
            try 
            {
                try 
                {
                    checked 
                    {
                        sh = (byte)notbyte; 
                    }
                    Console.WriteLine(sh); 
                }
                catch 
                {
                    Console.WriteLine("Сработал внутренний обработчик."); 
                    throw; 
                }
            }
            catch 
            {
                Console.WriteLine("Сработал внешний обработчик."); 
            }
            finally
            {
                sh = (byte)notbyte;
                Console.WriteLine(sh);
            }
            Console.ReadLine();
        }
    }
}