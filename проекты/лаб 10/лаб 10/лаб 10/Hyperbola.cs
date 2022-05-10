using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace лаб_10
{
    class Hyperbola:Function//наследование от класса Function
    {
        public Hyperbola(double a,double x) {
            this.a = a;
            this.x = x;
            
        }
        public override double formula()
        {
            this.y = a / x;
            Console.Write("y = {0}", y);
            return y;

        }
        public override void Print()
        {
            Console.WriteLine("Тип функции - Гипербола, a - {0}, x - {1}",a,x);
        }
    }
}
