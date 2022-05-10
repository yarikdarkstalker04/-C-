using System;

namespace Lab12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 2;
                Random rand = new Random();
                string Message = "Ошибка-IndexOutOfRangeException";
                int[] Array;
                Array = new int[n];
                Console.WriteLine("Массив:");
                for (int k = 0; k < n; k++) 
                {
                    Array[k] = rand.Next(-10, n);
                    Console.Write(Array[k] + " ");
                }
                Console.WriteLine();
                try
                {
                    Console.WriteLine(Array[n]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine(Message);
                }
                int i = 10 * n;
                int j = 5 + n;
                while (j != -10)
                {
                    try
                    {
                        Console.Write((i % j) + " ");
                    }
                    catch (DivideByZeroException)

                    {
                        Console.WriteLine("Делить на ноль нельзя!");
                    }
                    i += 3;
                    j += -1;

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}
