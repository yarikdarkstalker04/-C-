using System;

namespace ConsoleApp2
{
    interface Ix
    {
        void IxF0(double w);
        void IxF1();
    }
    interface Iy
    {
        void F0(double w);
        void F1();
    }
    interface Iz
    {
        void F0(double w);
        void F1();
    }
    class TestClass : Ix, Iy, Iz
    {
        double w;
        public TestClass(double ww)
        {
            w = ww;
        }
        public TestClass()
        {
            w = 1;
        }
        public void IxF0(double ww)
        {
            w = Math.Cos(ww);
            Console.WriteLine("cos({0}) = {1}", ww, w);
        }
        public void IxF1()
        {
            Console.Write("cos({0}) =", w);
            w = Math.Cos(w);
            Console.WriteLine("{0}", w);
        }
        public void F0(double ww)
        {
            w = Math.Exp(ww);
            Console.WriteLine("Exp({0}) = {1}", ww, w);
        }
        public void F1()
        {
            Console.Write("Exp({0}) =", w);
            w = Math.Exp(w);
            Console.WriteLine("{0}", w);
        }
        void Iz.F0(double ww)
        {
            w = 1 / Math.Exp(ww);
            Console.WriteLine("1/Exp({0}) = {1}", ww, w);
        }
        void Iz.F1()
        {
            Console.Write("1/Exp({0}) =", w);
            w = 1 / Math.Exp(w);
            Console.WriteLine(" {0}", w);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            TestClass ob = new TestClass(7);
            ob.IxF0(7);
            ob.IxF1();
            (ob as Iy).F0(12);
            (ob as Iz).F0(12);
            (ob as Iy).F1();
            (ob as Iz).F1();
            Iy y_ob;
            y_ob = ob;
            y_ob.F0(12);
            y_ob.F1();
            Iz z_ob;
            z_ob = ob;
            z_ob.F0(12);
            z_ob.F1();
            string wait = Console.ReadLine();
        }

    }
}

