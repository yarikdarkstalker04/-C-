using System;

namespace Lab13_14_1
{
    class Program
    {
        class KeyEventArgs: EventArgs
        {
            public char chr;
        }

        delegate void KeyHandler(object source, KeyEventArgs args);

        class keyEvent
        {
            public event KeyHandler KeyPress;

            public void OnKeyPress(char key)
            {
                KeyEventArgs k = new KeyEventArgs();

                if (KeyPress != null)
                {
                    k.chr = key;
                    KeyPress(this, k);
                }
            }
        }

        class ProcessKey
        {
            public void keyHandler(object source, KeyEventArgs arg)
            {
                Console.WriteLine("Получено сообщение о нажатии клавиши: {0}", arg.chr);
            }
        }

        class CountKeys
        {
            public int count = 0;

            public void keyHandler(object source, KeyEventArgs arg)
            {
                count++;
            }
        }

        static void Main(string[] args)
        {
            Console.Title = " Создание массива символов";
            ConsoleKeyInfo ckl;
            string Str = "";
            Console.WriteLine(" Вывод символов в массив. " +
                "(для прекращения ввода нажмите <F1>)\n");
            keyEvent kevt = new keyEvent();
            ProcessKey pk = new ProcessKey();
            CountKeys ck = new CountKeys();
            char cki;

            kevt.KeyPress += new KeyHandler(pk.keyHandler);
            kevt.KeyPress += new KeyHandler(ck.keyHandler);
            do
            {
                ckl = Console.ReadKey();
                cki = ckl.KeyChar;
                kevt.OnKeyPress(cki);
                Str += cki;
            } while (ckl.Key != ConsoleKey.F1);
            Console.WriteLine(" Массив символов: {0}",Str);
            Console.ReadKey();
        }
    }
}
