using System;
using System.Text.RegularExpressions;
namespace Example
{
    class Triangle
    {
        int a;
        int b;
        int c;
        public int[] storoni
        {
            get
            {
                int[] arr = new int[] { a, b, c };//индексатор
                return arr;
            }
            set
            {
                if (value[0] < 1 || value[1] < 1 || value[2] < 1)
                {
                    Console.WriteLine("Треугольник с такими сторонами не может существовать");
                }
                else if (value[0] > value[1] + value[2])
                {
                    Console.WriteLine("Треугольник с такими сторонами не может существовать");
                }
                else if (value[1] > value[0] + value[2])
                {
                    Console.WriteLine("Треугольник с такими сторонами не может существовать");
                }
                else if (value[2] > value[1] + value[0])
                {
                    Console.WriteLine("Треугольник с такими сторонами не может существовать");
                }
                else
                {
                    a = value[0];
                    b = value[1];
                    c = value[2];
                }
            }
        }
        public int this[int index]
        {
            get//свойство позволяющее получить-установить длины сторон треугольника 
            {
                if (index == 0)
                {
                    return a;
                }
                else if (index == 1)
                {
                    return b;
                }
                else if (index == 2)
                {
                    return c;
                }
                else
                {
                    Console.WriteLine("Нет сторон соответствующмх данному индексу");
                    return 0;
                }
            }
            set//свойство позволяющее установить, существует ли треугольник с данными длинами сторон
            {
                if (index == 0)
                {
                    if (value > 0) { a = value; }
                    else { Console.WriteLine("Сторона должна иметь положительную длинну"); }

                }
                else if (index == 1)
                {
                    if (value > 0) { b = value; }
                    else { Console.WriteLine("Сторона должна иметь положительную длинну"); }

                }
                else if (index == 2)
                {
                    if (value > 0) { c = value; }
                    else { Console.WriteLine("Сторона должна иметь положительную длинну"); }

                }
                else
                {
                    Console.WriteLine("Нет сторон соответствующмх данному индексу");

                }
            }
        }
        public Triangle(int a, int b, int c)//конструктор с заданными координатами
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Triangle()//конструктор с незаданными координатами
        {
            this.a = 1;
            this.b = 1;
            this.c = 1;
        }
        public static Triangle operator ++(Triangle ekz)//перегрузка операции ++
        {
            ekz.a++;
            ekz.b++;
            ekz.c++;
            ekz.storoni = new int[] { ekz.a, ekz.b, ekz.c };
            return ekz;
        }
        public static Triangle operator --(Triangle ekz)//перегрузка операции --
        {
            ekz.a--;
            ekz.b--;
            ekz.c--;
            ekz.storoni = new int[] { ekz.a, ekz.b, ekz.c };
            return ekz;
        }
        public static Triangle operator *(Triangle ekz, int skalyar)//перегрузка операции *
        {
            ekz.a *= skalyar;
            ekz.b *= skalyar;
            ekz.c *= skalyar;
            ekz.storoni = new int[] { ekz.a, ekz.b, ekz.c };
            return ekz;
        }
        public static bool operator true(Triangle ekz)//перегрузка константы true
        {
            if (ekz.a > ekz.b + ekz.c)
            {
                return false;
            }
            if (ekz.b > ekz.a + ekz.c)
            {
                return false;
            }
            if (ekz.c > ekz.b + ekz.a)
            {
                return false;
            }
            return true;


        }
        public static bool operator false(Triangle ekz)//перегрузка константы false
        {
            if (ekz.a > ekz.b + ekz.c)
            {
                return true;
            }
            if (ekz.b > ekz.a + ekz.c)
            {
                return true;
            }
            if (ekz.c > ekz.b + ekz.a)
            {
                return true;
            }
            return false;
        }
        public void Print()//метод вывода информации об экземпляре обьекта
        {
            Console.WriteLine("Длина стороны a - {0};\nДлина стороны b - {1}\nДлина стороны c - {2}", a, b, c);
        }
        public void Perimetr()//метод подсчета и вывода периметра 
        {
            Console.WriteLine("Периметр треугольника - {0}", a + b + c);
        }
        public void Ploshad()//метод подсчета и вывода площади
        {
            double p = (a + b + c) / 2;
            double h = 2 * (Math.Sqrt(p * (p - a) * p * (p - b) * p * (p - c)) / a);
            Console.WriteLine("Площадь треугольника - {0}", (h * a) / 2);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.Write("Введите длинну стороны a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите длинну стороны b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите длинну стороны c: ");
            int c = int.Parse(Console.ReadLine());
            Triangle triugolnik = new Triangle(a, b, c);
            bool chek = false;
            while (chek == false)
            {
                if (triugolnik)
                {
                    chek = true;
                    break;
                }
                Console.WriteLine("Одна сторона треугольнbка не должна быть больше суммы остальных сторон!!!\n");
                Console.Write("Введите длинну стороны a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Введите длинну стороны b: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Введите длинну стороны c: ");
                c = int.Parse(Console.ReadLine());
                triugolnik = new Triangle(a, b, c);
            }
            triugolnik.Print();
            triugolnik.Perimetr();
            triugolnik.Ploshad();
            Console.WriteLine("Стороны треугольника после операции ++");
            triugolnik++;
            triugolnik.Print();
            Console.WriteLine("Стороны треугольника после операции --");
            triugolnik--;
            triugolnik.Print();
            Console.Write("Введите число на которое хотите умножить стороны треугольника:");
            int skalyar = int.Parse(Console.ReadLine());
            Console.WriteLine("Стороны треугольника после операции *");
            triugolnik *= skalyar;
            triugolnik.Print();

            Console.WriteLine("Введите индекс стороны треугольника, значение которой хотите увидеть\n(0- a, 1 - b, 2 - c, любое другое целое число, чтобы закончить просмотр)");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(triugolnik[n]);
            while (triugolnik[n] > 0)
            {
                Console.WriteLine("Введите индекс стороны треугольника, значение которой хотите увидеть\n(0- a, 1 - b, 2 - c, любое другое целое число, чтобы закончить просмотр)");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine(triugolnik[n]);
            }
            Console.Write("Нажмите Enter...");
            Console.Read();
        }
    }
}





