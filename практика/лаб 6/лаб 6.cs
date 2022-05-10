using System;

namespace ConsoleApp2
{
    class Sotrudnik{
        protected string name;
        protected double p;
        double k;
      public Sotrudnik(string name, double p) {
        this.name = name;
        this.p = p;
        this.k=1;
      }
      public string Name {
        get{return name;}
          set { name = value; }
    }
    public double P {
        get{return p;}
        set { p = value; }
    }
    public double dohod () {
        return k*p;
      }
    public void show() {
      Console.Write("Имя:{0}; Минимальная ЗП:{1}; ",name,p);
    }
    }
    class Engineer:Sotrudnik{
        int n;
        public Engineer(string name, double p, int n)
            : base(name, p)
        {
            this.n = n;
            this.p = base.p*(n / 10);
        }
        public void show() {
            base.show();
            Console.Write("Кол-во проектов:{0} ",n);
        }
    }
    class Program
    { 

        static void Main(string[] args)
        {
            Sotrudnik rabochii1 = new Sotrudnik("Имя 1",700);
            Engineer rabochii2 = new Engineer("Имя 2", 700,20);
            rabochii1.show();
            Console.WriteLine();
            rabochii2.show();
            string wait = Console.ReadLine();
        }
        
    }
}
