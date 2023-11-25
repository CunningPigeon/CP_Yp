using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LB_7
{
    internal class Program
    {
        static void Main()
        {
            string text = @"Контакты в Москве tel:123 - 45 - 67, 123 - 34 - 56; fax: 123 - 56 - 45.
            Контакты в Саратове tel:12 - 34 - 56; fax: 12 - 56 - 45 ";
            Console.WriteLine("Старые данные\n " + text); 

            string newText = Regex.Replace(text, @"[а-яА-я]?", ""); // Удаляет все русские слова(буквы)
            // Регулярное выражение [а-яА-я]?
            Console.WriteLine("Новые данные\n " + newText);

            Console.ReadKey();
        }
    }
}

