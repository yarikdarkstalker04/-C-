using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace лаб_10
{
    abstract class Function : IComparable
    {
        protected double y;
        protected double a;
        protected double b;
        protected double c;
        protected double x;
        abstract public double formula();
        abstract public void Print();
        public int CompareTo(object obj)
        {
            Function bb = (Function)obj;
            if (this.a == bb.a)
            {
                return 0;
            }
            else if (this.a > bb.a)
            {
                return 1;   
            }
            else
            {
                return -1;
            }
        }
    }
}
