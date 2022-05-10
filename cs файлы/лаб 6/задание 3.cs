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
Console.WriteLine("Введите СИМВОЛ b:");
char b=char.Parse(Console.ReadLine());
int k=0;
for (int x=0;x<a.Length; x++)
{
if (a[x]==b)
{
k++;
}
}
Console.WriteLine("Символ {0} содержится в строке {1} раз", b, k );
string wait = Console.ReadLine();
}
}
}




