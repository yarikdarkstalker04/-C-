using System;
using System.Collections;
using System.IO;
using System.Text;
namespace ConsoleApp2
{
        
  class Program
{
    static void Print(char[] a)
    {
            foreach (char elem in a)
            {
                Console.Write(elem);
            }
            Console.WriteLine();
    }
        

static void Main()
{
    char[] a ={ 'm', 'a', 'Х', 'i', 'M', 'u', 'S' , '!', '!', '!' };
    Console.WriteLine("Исходный массив а:");
    int count_of_punc = 0;
    Print(a);
    for (int x=0;x<a.Length; x++)
    {
        if (char.IsPunctuation(a[x]))
    {
        count_of_punc++;
    }
    }
    Console.WriteLine("Количество знаков припенания в массиве а: ",count_of_punc);
    //преобразование строки в массив символов
    char [] b="кол около колокола".ToCharArray();
    Console.WriteLine("Исходный массив b:");
    Print(b);
    Array.Sort(b);
    Console.WriteLine("Измененный массив b:");
    Print(b);
string wait = Console.ReadLine();
}
}
}


