using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace лаб_10
{
    class Line : Function//наследование от класса Function
    {
        public Line(double a, double b,double x) {
            this.x = x;
            this.a = a;
            this.b = b;
            
        }
        public override double formula()
        {
            this.y = a * x + b;
            Console.Write("y = {0}", y);
            return y;
        }
        public override void Print()
        {
            Console.WriteLine("Тип функции - Линия, a - {0}, b - {1}, x - {2}",a,b,x);
        }
    }
}
