using System;

namespace ConsoleApp2
{
    abstract class Transport{
        public string name;
        public string type_of_transport;
        public int cost;
        public Transport(string nam) {
            name = nam;
        }
        abstract public void Print(); 
    }
    class Plane : Transport {
        int h;
        int v;
        public Plane (string name, int h1, int v1) : base(name) { 
            h = h1;
            v = v1;
            cost = 100 * v * h;
            type_of_transport = "plane";
        }
        override public void Print() {
            Console.WriteLine("Стоимость Самолета \"{0}\" - {1}",name,cost);
        }
    }
    class Ship : Transport {
        int k;
        string port;
        public Ship(string name, int k1, string port1):base(name) {
            k = k1;
            port = port1;
            cost = k*k*5;
            type_of_transport = "ship";
        }
        override public void Print()
        {
            Console.WriteLine("Стоимость Корабля \"{0}\" - {1}", name, cost);
        }
    }
    class Program
    { 

        static void Main(string[] args)
        {
            const int n = 6;
            double cost_plane = 0;
            int count_plane = 0;
            double cost_ship = 0;
            int count_ship = 0;
            Transport[] st = new Transport[n];
            st[0]= new Plane("plane-231",3,200);
            st[1] = new Ship("ship-762",100,"port34");
            st[2] = new Plane("plane-542", 2, 300);
            st[3] = new Ship("ship-76", 1043, "port51");
            st[4] = new Plane("plane-28", 3, 175);
            st[5] = new Ship("ship-710", 100, "port754");
            foreach (Transport elem in st) {
                if (elem.type_of_transport == "plane")
                {
                    cost_plane += elem.cost;
                    count_plane++;
                }
                else
                {
                    if (elem.type_of_transport == "ship")
                    {
                        cost_ship += elem.cost;
                        count_ship++;
                    }
                }
            }
            cost_plane = cost_plane / count_plane;
            cost_ship = cost_ship / count_ship;
            Console.WriteLine("Средняя стоимость всех самолетов - {0}\nСредняя стоимость всех кораблей - {1}",cost_plane,cost_ship);
            string wait = Console.ReadLine();
        }
        
    }
}
