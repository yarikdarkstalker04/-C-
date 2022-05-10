using System;
using System.Text.RegularExpressions;
namespace Example
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите количество сотрудников, которое хотите добавить:");
            int n = int.Parse(Console.ReadLine());
            Sotrudnik[] rabochie = new Sotrudnik[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите фамилию сотрудника:");
                string fam = Console.ReadLine();
                Console.Write("Введите имя сотрудника:");
                string nam = Console.ReadLine();
                Console.Write("Введите отчество сотрудника:");
                string otc = Console.ReadLine();
                Console.Write("Введите должность сотрудника:");
                string dol = Console.ReadLine();
                Console.Write("Введите год рождения сотрудника:");
                int dat = int.Parse(Console.ReadLine());
                Console.Write("Введите зарплату сотрудника:");
                int zar = int.Parse(Console.ReadLine());
                Console.WriteLine();
                rabochie[i] = new Sotrudnik(fam, nam, otc, dol, dat, zar);
            }
            for (int i = 0; i < n; i++)
            {
                rabochie[i].print();
            }
            Console.WriteLine("Введите фамилию сотрудника, которого хотите удалить из списка");
            string delete_fam = Console.ReadLine();
            Console.Write("Введите количество сотрудников, которое хотите добавить:");
            int k = int.Parse(Console.ReadLine());
            int chek = 0;
            foreach (Sotrudnik raboci in rabochie)
            {
                if (raboci.Fam == delete_fam) chek = 1;
            }
            Sotrudnik[] rabochie_red = new Sotrudnik[n + k - chek];
            int step = 0;
            if (chek == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    if (rabochie[i].Fam == delete_fam)
                    {
                        step = 1;
                        continue;
                    }
                    rabochie[i - step] = rabochie[i];
                }
            }
            for (int i = 0; i < rabochie.Length; i++)
            {
                rabochie_red[i] = rabochie[i];
            }
            for (int i = n - chek; i < k + n - chek; i++)
            {
                Console.Write("Введите фамилию сотрудника:");
                string fam = Console.ReadLine();
                Console.Write("Введите имя сотрудника:");
                string nam = Console.ReadLine();
                Console.Write("Введите отчество сотрудника:");
                string otc = Console.ReadLine();
                Console.Write("Введите должность сотрудника:");
                string dol = Console.ReadLine();
                Console.Write("Введите год рождения сотрудника:");
                int dat = int.Parse(Console.ReadLine());
                Console.Write("Введите зарплату сотрудника:");
                int zar = int.Parse(Console.ReadLine());
                Console.WriteLine();
                rabochie_red[i] = new Sotrudnik(fam, nam, otc, dol, dat, zar);
            }
            foreach (Sotrudnik raboci in rabochie_red)
            {
                raboci.print();
            }
            string wait = Console.ReadLine();
        }
        struct Sotrudnik
        {
            public string Fam;
            public string Nam;
            public string Otc;
            public string dolznost;
            public int born_year;
            public int zp;

            public Sotrudnik(string f, string n, string o, string d, int b, int z)
            {
                Fam = f;
                Nam = n;
                Otc = o;
                dolznost = d;
                born_year = b;
                zp = z;
            }
            public void print()
            {
                Console.WriteLine("ФИО: {0} {1} {2}\nДолжность: {3}\nГод рождени: {4}\nЗаработная плата: {5}", Fam, Nam, Otc, dolznost, born_year, zp);
            }

        }
    }
}





