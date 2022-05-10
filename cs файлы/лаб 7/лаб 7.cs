using System;
using System.Text.RegularExpressions;
namespace Example
{
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string str = Console.ReadLine();
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Regex find_word = new Regex(@"\b(\w){"+n+@"}\b");
        Match fin_str = find_word.Match(str);
        if (find_word.IsMatch(str))
        {
            while (fin_str.Success)
            {
                Console.WriteLine(fin_str);
                fin_str = fin_str.NextMatch();
            }
        }
        else {
            Console.WriteLine("Слов с длинной {0} не обнаружено",n);
        }
        string wait = Console.ReadLine();
    }
}
}





