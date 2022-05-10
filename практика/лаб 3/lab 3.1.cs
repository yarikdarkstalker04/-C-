using System;

namespace ConsoleApp2
{
    class laba3v2{
        public int a;
        int b;
        int x;
        public int mya{
            get { return a; }
            set{ if(value>=0) a = value;}
    }
           public laba3v2(int a,int b) {
               this.a = a;
               this.b = b;
           }
           public laba3v2() {
                this.a = 1;
                this.b = 2;
           }
           public void reshenie() { 
               x =(-1*b)/a ;
               if (b>=0){
                Console.WriteLine("x в уравнении {0}x+{1}=0 равен {2}",a,b,x);
           }
               else {
                Console.WriteLine("x в уравнении {0}x{1}=0 равен {2}",a,b,x);
               }
           }
        }
    class Program
    { 

        static void Main(string[] args)
        {
            laba3v2 zadanie1 = new laba3v2(3,-15);
            zadanie1.reshenie();
            zadanie1 = new laba3v2();
            zadanie1.reshenie();
            
            
            string wait = Console.ReadLine();
        }
        
    }
}
