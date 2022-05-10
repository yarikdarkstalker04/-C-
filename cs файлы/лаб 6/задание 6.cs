using System;
//подключили пространство имен для работы с классом StringBuilder
using System.Text;
namespace Example
{
class Program
{
static void Main()
{
Console.WriteLine("Введите строку: ");
StringBuilder a = new StringBuilder(Console.ReadLine());
int count = 0;
for (int i=0; i<a.Length;) //удаляем из строк все знаки пунктуации
{
if (char.IsPunctuation(a[i]))
{
    count = 0;
    a.Remove(i,1);
}
else if (a[i] == ' ')
{
    count++;
    if (count >= 2)
    {
        a.Remove(i, 1);
    }
    else i++;

}
else {
    count = 0;
    i++;
}
    
}
//преобразуем объект StringBuilder к типу string, и разбиваем его на массив слов
string []s=a.ToString().Split(' ');
Console.WriteLine("Искомые слова: ");
//перебираем все слова в массиве слов и выводим на экран те, которые
//начинаются и заканчиваются на одну и туже букву
foreach (string str in s)
{
if (str[0]==str[str.Length-1])
{
Console.WriteLine(str);
}
}
string wait = Console.ReadLine();
}
}
}





