using System;
//подключили пространство имен для работы с классом StringBuilder
using System.Text;
namespace Example
{
class Program
{
    static int LastIndexOf(StringBuilder str1, StringBuilder str2)
    {
        int i, j,count,index;
        for (i = str1.Length - 1; i >= (str1.Length-1)- (str2.Length - 1); i--)
        {
            count = 0;
            index = str2.Length-1;
            for (j = i;j>=i-(str2.Length-1);j--)
            {
                if (str1[j] == str2[index]) {
                    count++;
                }
                index--;
            }
            if (count == str2.Length) {
                return i-(str2.Length-1);
            }
        }
        return -1;
    }
static void Main(){
 StringBuilder str=new StringBuilder("кол около колокола");
StringBuilder x=new StringBuilder("кол");
StringBuilder y=new StringBuilder("!!!");
int n= LastIndexOf(str, x);
str.Insert(n+x.Length, y);
Console.WriteLine(str);
string wait = Console.ReadLine();
}
}
}




