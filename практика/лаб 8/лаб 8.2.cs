using System;
using System.Collections;
using System.IO;
using System.Text;
namespace ConsoleApp2
{

    class Student : IComparable
    {
        public string fio;
        public int kurs;
        public string grup;
        public int rezultat;
        public override string ToString()
        {
            return String.Format("ФИО: {0}; Курс: {1}; Группа: {2}; Результат: {3}.",fio,kurs,grup,rezultat);
        }
        public int CompareTo(object obj)
        {
            Student b;
            b = (Student)obj;
            return rezultat.CompareTo(b.rezultat);
        }
    }
    class SortByRezultat : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Student st1 = (Student)x;
            Student st2 = (Student)y;
            if (st1.rezultat < st2.rezultat) return 1;
            if (st1.rezultat > st2.rezultat) return -1;
            return 0;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            const int n = 5;
            ArrayList students = new ArrayList();
            ArrayList champions = new ArrayList();
            ArrayList final_champions = new ArrayList();
            Console.WriteLine("Введите данные о студентах с лучшими результатами:");
            for (int i = 0; i < n; i++)
            {
                Student a = new Student();
                Console.Write("ФИО: ");
                a.fio = Console.ReadLine();
                Console.Write("Курс: ");
                a.kurs = int.Parse(Console.ReadLine());
                Console.Write("Группа: ");
                a.grup = Console.ReadLine();
                Console.Write("Результат: ");
                a.rezultat = int.Parse(Console.ReadLine());
                students.Add(a);
            }
            students.Sort(new SortByRezultat());
            for (int i = 0; i < 3; i++){
                champions.Add(students[i]);
            }
            champions.Sort(new SortByRezultat());
            Console.WriteLine("Информация о студентах после сортировки:");
            foreach (Student a in students)
            {
                foreach (Student b in champions)
                {
                  if (a.rezultat>=b.rezultat)
                  {
                    final_champions.Add(a);
                    break;
                  }  
                }
            }
            final_champions.Sort(new SortByRezultat());
            foreach (Student chmp in final_champions)
            {
                Console.WriteLine("{0}",chmp);
            }
            string wait = Console.ReadLine();
        }

    }
}