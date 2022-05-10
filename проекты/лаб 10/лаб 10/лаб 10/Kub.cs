using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace лаб_10
{
    class Kub : Function//наследование от класса Function
    {
        public Kub(double a, double b, double c, double x) {
            this.a = a;
            this.b = b;
            this.c = c;
            this.x = x;
        }
        public override double formula()
        {
            this.y = a * x * x + b * x + c;
            Console.Write("y = {0}",y);
            return y;
            
        }
        public override void Print()
        {
            Console.WriteLine("Тип функции - Куб, a - {0}, b - {1}, c - {2}, x - {3}",a,b,c,x);
        }
    }
}
