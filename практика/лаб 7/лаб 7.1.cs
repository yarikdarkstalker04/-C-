using System;

namespace ConsoleApp2
{
    class Transport{
        public string name;
        public Transport(string nam) {
            name = nam;
        }
        virtual public void Print() {
            Console.WriteLine("Название - {0}", name);
        }
    }
    class Plane : Transport {
        int h;
        int v;
        public Plane (string name, int h1, int v1) : base(name) { 
            h = h1;
            v = v1;
        }
        override public void Print() {
            Console.WriteLine("Стоимость Самолета \"{0}\" - {1}",name,100*v*h);
        }
    }
    class Ship : Transport {
        int k;
        string port;
        public Ship(string name, int k1, string port1):base(name) {
            k = k1;
            port = port1;
        }
        override public void Print()
        {
            Console.WriteLine("Стоимость Корабля \"{0}\" - {1}", name, 5 * k * k);
        }
    }
    class Program
    { 

        static void Main(string[] args)
        {
            const int n = 7;
            Transport[] st = new Transport[n];
            st[0]= new Plane("plane-231",3,200);
            st[1] = new Ship("ship-762",100,"port34");
            st[2] = new Plane("plane-542", 2, 300);
            st[3] = new Ship("ship-76", 1043, "port51");
            st[4] = new Plane("plane-28", 3, 175);
            st[5] = new Ship("ship-710", 100, "port754");
            st[6] = new Transport("Auto-432");
            foreach (Transport elem in st) {
                elem.Print();
            }
            string wait = Console.ReadLine();
        }
        
    }
}
