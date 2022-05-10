using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace лаб_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.FullName;
            var filePathT1 = Path.Combine(appRootDir, "..\\T1.txt");//присваивание пути к файлу Т1 переменной
            var filePathT2 = Path.Combine(appRootDir, "..\\T2.txt");
            FileStream T1 = new FileStream(filePathT1, FileMode.Open);//связывание переменной filePathT1 с текстовым файлом Т1
            FileStream T2 = new FileStream(filePathT2, FileMode.Create);//связывание переменной filePathT2 с созданным текстовым файлом Т2
            StreamReader reader = new StreamReader(T1);//открытие для чтения текствого файла Т1
            StreamWriter writer = new StreamWriter(T2);//открытие для записи текствого файла Т1
            string reader_str = reader.ReadToEnd();//получение текста из файла Т1 в переменную reader_str
            int n = 0;//cчетчик символов
            for (int i = 0; i < reader_str.Length; i++) {
                writer.Write(reader_str[i]);
                n++;
                if (reader_str[i] == ';' || n>30)
                {
                    writer.WriteLine("");
                    n = 0;
                }
                
            }
                reader.Close();//закрытие текстового файла Т1
                writer.Close();//закрытие текстового файла Т1
        }
    }
}
