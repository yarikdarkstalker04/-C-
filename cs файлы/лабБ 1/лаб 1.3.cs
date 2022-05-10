using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace лаб_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите двухзначное число");
            int a  = int.Parse(Console.ReadLine());
            double ab = a/10;
            string chek = (a % 10 == Math.Floor(ab))?"NF":"NNF";
            string result = (chek == "NF")?"цифры равнозначны":(a % 10 > Math.Floor(ab))?"меньше первая цифра":"меньше вторая цифра";
            Console.WriteLine(result);
            Console.WriteLine("нажмите ENTER");
            string chch = Console.ReadLine();
        }
    }
}
