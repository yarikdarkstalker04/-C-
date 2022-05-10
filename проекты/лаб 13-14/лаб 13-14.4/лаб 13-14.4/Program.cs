using System;

namespace Lab13_14_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            string carName = "Ford";
            Console.Write("Название автомобиля - {0}\n" +
                "Введите название автомобиля - ",carName);
            string newCarName = Console.ReadLine();
            Console.WriteLine("     Изменить название?(да - клавиша <Y>, нет - клавиша <N>)");
            cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.Y:
                    if (carName != newCarName)
                    {
                        Console.WriteLine("     Название изменилось!\n" +
                        "Новое название автомобиля - {0}\n",newCarName);
                    }
                    else
                    {
                        Console.WriteLine("     Название не изменилось!\n" +
                        "Название автомобиля - {0}\n",carName);
                    }
                    break;

                case ConsoleKey.N:
                    Console.WriteLine("     Название не изменилось!\n" +
                        "Название автомобиля - {0}\n",carName);
                    break;
            }
            Console.ReadKey();   
        }
    }
}
    