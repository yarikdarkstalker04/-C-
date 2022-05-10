using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWords=0;
            string chek = Console.ReadLine();
            for(int i=0;i<chek.Length;i++){
                 while (char.IsLetterOrDigit(chek[i])) { 
                    i++;
                    if (i == chek.Length) {
                        break;
                    }
                }
                countOfWords++;
              }
            string[] fullSlovo= new string[countOfWords];
            string[] fullSlovoSorted = new string[countOfWords];
            int[] dlinaSlov = new int[countOfWords];
            int idOfArray = 0;
            for (int i = 0; i < chek.Length;i++)
            {
                if (char.IsLetterOrDigit(chek[i]) == false)
                {
                    continue;
                }
                string slovo="";
                while (char.IsLetterOrDigit(chek[i])) { 
                    slovo+=chek[i];
                    i++;
                    if (i == chek.Length) {
                        break;
                    }
                }
                if (idOfArray == 0)
                {
                    fullSlovo[0] = slovo;
                    fullSlovoSorted[0] = " ";
                    dlinaSlov[0] = slovo.Length;
                    idOfArray++;
                }
                else {
                    fullSlovo[idOfArray] = slovo;
                    fullSlovoSorted[idOfArray] = " ";
                    dlinaSlov[idOfArray] = slovo.Length;
                    idOfArray++;
                }
    
            }
            Array.Sort(dlinaSlov);
            for (int i = 0; i < fullSlovo.Length; i++) {
                for (int j = 0; j < dlinaSlov.Length; j++) { 
                    if (fullSlovo[i].Length==dlinaSlov[j]) {
                        if (fullSlovoSorted[j]==" ") {
                            fullSlovoSorted[j] = fullSlovo[i];
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < fullSlovoSorted.Length; i++) {
                Console.Write("{0} ",fullSlovoSorted[i]);
            }
            string stt = Console.ReadLine();
        }
        
    }
}
