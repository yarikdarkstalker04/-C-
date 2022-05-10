using System;
namespace ConsoleApp2
{
        
class Program
{
static void Main()
{
string poems = "тучки небесные вечные странники";
char[] div = {' '}; //создаем массив разделителей
// Разбиваем строку на части,
string[] parts = poems.Split(div);
Console.WriteLine("Результат разбиения строки на части: ");
for (int i = 0; i<parts.Length; i++)
{
Console.WriteLine(parts[i]);
}
// собираем эти части в одну строку, в качестве разделителя используем
// символ |

Array.Reverse(parts);
string whole = String.Join(" | ",parts);
Console.WriteLine("Результат сборки: ");
Console.Write(whole);
string wait = Console.ReadLine();
}
}
}




