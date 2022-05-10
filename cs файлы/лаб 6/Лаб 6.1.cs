using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string chek = Console.ReadLine();
            int countOk = 1;
            for (int i = 1; i < chek.Length;i++)
            {
                if(chek[i-1]<chek[i]) {
                    countOk++;
                }
            }
            if (countOk == chek.Length)
            {
                Console.WriteLine("упорядочены");
            }
            else {
                Console.WriteLine("не упорядочены");
            }
            string stt = Console.ReadLine();
        }
        
    }
}
