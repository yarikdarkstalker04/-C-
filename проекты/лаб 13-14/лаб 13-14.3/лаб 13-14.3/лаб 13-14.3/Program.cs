using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace лаб_13_14._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = "Ford";
            Console.Write("Название автомобиля - {0}\n" +
                "введите название автомобиля - ",carName);
            string newCarName = Console.ReadLine();
            if (carName!=newCarName)
            {
                Console.WriteLine("     Название изменилось!\n" +
                "Новое название автомобиля - {0}\n",newCarName);
            }
            else
            {
                Console.WriteLine("     Название не изменилось!\n" +
                "Название автомобиля - {0}\n",carName);
            }
            Console.ReadKey();
        }
    }
}

        
    

