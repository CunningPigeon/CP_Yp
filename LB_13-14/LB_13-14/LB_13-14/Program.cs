using LB_13_14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_13_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            KeyEvent k_event = new KeyEvent(); // Создаём экземпляр класса KeyEvent (делегат)
            KeyProcess kp = new KeyProcess(); // Создаём экземпляр класса  
            KeyCounter kc = new KeyCounter(); // Создаём экземпляр класса KeyCounter
            // Добавляем в делегат методы
            k_event.KeyPress += new KeyHandler(kp.keyhandler);
            k_event.KeyPress += new KeyHandler(kc.keyhandler);
            // Задаём переменную для введённых клавиш
            ConsoleKeyInfo ch;
            do
            {
                // Считываем клавишу
                ch = Console.ReadKey(true);
                
                k_event.OnKeyPress(ch); // Передаем её в событие
            } while (ch.KeyChar != '!');
            // Выводим массив символов
            Console.WriteLine("Массив символов: " + kc.chars.Replace("!", ""));
            Console.ReadKey();
        }


        class KeyEventArgs : EventArgs
        {
            public ConsoleKeyInfo ch;
        }
        delegate void KeyHandler(object source, KeyEventArgs arg);

        class KeyEvent
        {
            public event KeyHandler KeyPress;
            public void OnKeyPress(ConsoleKeyInfo key)
            {
                KeyEventArgs k = new KeyEventArgs();
                if (KeyPress != null)
                {
                    k.ch = key;
                    KeyPress(this, k);
                }
            }
        }

        class KeyCounter
        {
            public string chars;

            public void keyhandler(object source, KeyEventArgs arg)
            {
                chars += arg.ch.KeyChar;
            }
        }
        class KeyProcess
        {
            public void keyhandler(object source, KeyEventArgs arg)
            {
                if (Char.IsLetter(arg.ch.KeyChar))
                {
                    Console.WriteLine($"Была нажата клавиша: {arg.ch.Key}, символ которой {arg.ch.KeyChar}");
                }
            }
        }
    }
}

