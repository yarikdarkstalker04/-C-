using System;

namespace ConsoleApp2
{
    class Lab_Array_v2{
        int a;
        int b;
        string[,] arr;
        public string otvet ="";
        void zapolnenie(int a, int b) {
            this.a = a;
            this.b = b;
            string chek;
            this.arr = new string[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("Элемент [{0},{1}] - ", i, j);
                    chek = Console.ReadLine();
                    for (int l = 0; l < chek.Length; l++)
                    {
                        if (char.IsDigit(chek[l]) == false)
                        {
                            chek = "";
                            break;
                        }
                    }
                    if (chek != "")
                    {
                        arr[i, j] = chek;
                    }
                    else
                    {
                        while (chek == "")
                        {
                            Console.WriteLine("Введите целое число!");
                            Console.Write("Элемент [{0},{1}] - ", i, j);
                            chek = Console.ReadLine();
                            for (int l = 0; l < chek.Length; l++)
                            {
                                if (char.IsDigit(chek[l]) == false)
                                {
                                    chek = "";
                                    break;
                                }
                            }
                            if (chek != "")
                            {
                                arr[i, j] = chek;
                            }
                        }
                    }
                }

            }
        }
           public Lab_Array_v2(int a,int b) {
               zapolnenie(a,b);
           }
           public Lab_Array_v2()
           {
                this.a = 3;
                this.b = 3;
                zapolnenie(a, b);

           }
           public void reshenie() {
               int chet;
               int ne_chet;
               for (int i = 0; i < a; i++) {
                   chet = 0;
                   ne_chet = 0;
                   for (int j = 0; j < a; j++) {
                       for (int l = 0; l < arr[i, j].Length;l++ )
                       {
                           if (int.Parse(arr[i, j][l].ToString()) % 2 == 0)
                           {
                               chet += int.Parse(arr[i, j][l].ToString());
                           }
                           else
                           {
                               ne_chet += int.Parse(arr[i, j][l].ToString());
                           }
                       }
                   }
                   otvet = otvet + "Строка №"+(i+1)+": сумма четных цифр: "+chet+"; сумма нечетных цифр: "+ne_chet+".\n";
               }
               Console.WriteLine(otvet);
           }
           public void print_arr() {
               for (int i = 0; i < a; i++) {
                   Console.Write("[");
                   for (int j = 0; j < a; j++) {
                       Console.Write(" "+arr[i, j]);
                       
                   }
                   Console.WriteLine(" ]");
               }
           }
           string this[int i, int j] {
               get {
                   if (i >= 0 && i < a) {
                       if (j >= 0 && j < b)
                       {
                           return arr[i, j];
                       }
                       else {
                           Console.WriteLine("Введенный индекс выходит за границы массива");
                           return "0";
                       }
                   }
                   else { Console.WriteLine("Введенный индекс выходит за границы массива");
                   return "0";
                   }
               }
               set {
                   if (i >= 0 && i < a)
                   {
                       if (j >= 0 && j < b)
                       {
                           string chek;
                           chek = value;
                           for (int l = 0; l < chek.Length; l++)
                           {
                               if (char.IsDigit(chek[l]) == false)
                               {
                                   chek = "";
                                   break;
                               }
                           }
                           if (chek == "")
                           {
                               Console.WriteLine("Введенное значение некорректно");
                           }
                           arr[i, j] = chek;
                       }
                       else
                       {
                           Console.WriteLine("Введенный индекс выходит за границы массива");
                       }
                   }
                   else { 
                    Console.WriteLine("Введенный индекс выходит за границы массива");
                   }
               
               }
           }
       
        }
    class Program
    { 

        static void Main(string[] args)
        {
            Lab_Array_v2 zadanie1 = new Lab_Array_v2(3, 3);
            zadanie1.print_arr();
            zadanie1.reshenie();

            string wait = Console.ReadLine();
        }
        
    }
}
