using System;
//подключили пространство имен для работы с классом StringBuilder
using System.Text;
namespace Example
{
class Program
{
static void Main()
{
Console.WriteLine("Введите строку а:");
StringBuilder a = new StringBuilder(Console.ReadLine());
Console.Write("Введите символ b:");
char b = char.Parse(Console.ReadLine());
Console.Write("Введите символ c:");
char c = char.Parse(Console.ReadLine());
bool trouble = true;
while (trouble) {
    if (b == c)
    {
        Console.WriteLine("Введенные значения в переменных b и с совпадают!");
        Console.Write("Введите символ b:");
        b = char.Parse(Console.ReadLine());
        Console.Write("Введите символ c:");
        c = char.Parse(Console.ReadLine());
    }
    else {
        trouble = false;
    }
}
for (int x=0;x<a.Length; x++)
{
if (a[x]==b)
{
a[x]=c;
}
}
Console.WriteLine("Преобразованная строка: {0}",a );
string wait = Console.ReadLine();
}
}
}




