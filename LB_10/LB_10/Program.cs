using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LB_10
{
    public class Program
    {
        abstract public class Goods : IComparable<Goods>
        {
            abstract public void Move();
            abstract public void Examination();
            // abstract public int CompareTo();
            public int cost { set; get; }

            public int CompareTo(Goods other)
            {
                if (this.cost > other.cost)
                    return 1;
                else if (this.cost < other.cost)
                    return -1;
                else
                    return 0;
            }

        }

        public class Product: Goods
        {
            public String Name;
            public int quantity;
            public String time; // дата производства
            public int timeI;

            public Product(String Name, int quantity, String time, int timeI, int cost)
            {
                this.Name = Name;
                this.quantity = quantity;
                this.time = time;
                this.timeI = timeI; 
                this.cost = cost;
            }
            public override void Move()
            {
                Console.WriteLine("Информация о товаре: \n\tНаименование: {0} \n\tКоличество на складе: {1}\n\tДата изготовления: {2} \n\tСрок годности: {3} месяц(а/ов) \n\tЦена: {4}", Name, quantity, time, timeI, cost);
            }

            public override void Examination()
            {
                DateTime thisDay = DateTime.Today;
                string timeP = thisDay.ToString("d"); // Определение текущей даты

                string[] mass1, mass = new string[3];
                mass1 = timeP.Split('.');
                mass = time.Split('.');

                int a = int.Parse(mass[1]) + timeI;
                mass[1] = a.ToString();

                if (int.Parse(mass[1]) > 12)
                {

                    mass[0] = "01";
                    a = int.Parse(mass[1]) - timeI * 2;
                    if (a == 0)
                    {
                        mass[1] = "01";
                    }
                    else
                    {
                        mass[1] = a.ToString();
                    }
                    
                    a = 1 +  int.Parse(mass[2]);
                    mass[2] = a.ToString();
                }
                
                foreach (var mas in mass1)
                {
                    Console.WriteLine($"Текущая дата mass1: {mas}");
                }
                foreach (var mas in mass)
                {
                    Console.WriteLine($"Дата mass: {mas}");
                }

                for (int i = 0; i < mass.Length; i++)
                {
                    if (((int.Parse(mass1[0]) <= int.Parse(mass[0])) && (int.Parse(mass1[1]) <= int.Parse(mass[1]))) && (int.Parse(mass1[2]) <= int.Parse(mass1[2])))
                    {
                        Console.WriteLine("Срок годности не истек");
                    }
                    else
                    {
                        Console.WriteLine("Срок годности истек");
                    }
                }
                
            }
        }

        public class Party: Goods
        {
            public String Name;
            // public int cost = 5;
            public int quantity; // кол-во
            public String time; 
            public int timeI;

            public Party(string name, int quantity, string time, int timeI, int cost)
            {
                this.Name = name;
                this.quantity = quantity;
                this.time = time;
                this.timeI = timeI;
                this.cost = cost;
            }

            public override void Move()
            {
                Console.WriteLine("Информация о товаре: \n\tНаименование: {0} \n\tКоличество на складе: {1}\n\tДата изготовления: {2} \n\tСрок годности: {3} месяц(а/ов) \n\tЦена: {4}", Name, quantity, time, timeI, cost);
            }

            public override void Examination()
            {
                DateTime thisDay = DateTime.Today;
                string timeP = thisDay.ToString("d"); // Определение текущей даты

                string[] mass1, mass = new string[3];
                mass1 = timeP.Split('.');
                mass = time.Split('.');

                int a = int.Parse(mass[1]) + timeI;
                mass[1] = a.ToString();

                if (int.Parse(mass[1]) > 12)
                {

                    mass[0] = "01";
                    a = int.Parse(mass[1]) - timeI * 2;
                    if (a == 0)
                    {
                        mass[1] = "01";
                    }
                    else
                    {
                        mass[1] = a.ToString();
                    }

                    a = 1 + int.Parse(mass[2]);
                    mass[2] = a.ToString();
                }
/*
                foreach (var mas in mass1)
                {
                    Console.WriteLine($"Текущая дата mass1: {mas}");
                }
                foreach (var mas in mass)
                {
                    Console.WriteLine($"Дата mass: {mas}");
                }
*/
                for (int i = 0; i < mass.Length; i++)
                {
                    if (((int.Parse(mass1[0]) <= int.Parse(mass[0])) && (int.Parse(mass1[1]) <= int.Parse(mass[1]))) && (int.Parse(mass1[2]) <= int.Parse(mass1[2])))
                    {
                        Console.WriteLine("{0}: срок годности не истек", Name);
                    }
                    else
                    {
                        Console.WriteLine("{0}: срок годности истек", Name);
                    }
                }
            }

        }

        public class Kit: Goods
        {
            public String Name = "Ящик с мясом";
            // public int cost = 5;
            public string list;

            public Kit(string Name, string list, int cost)
            {
                this.Name = Name;
                this.list = list;
                this.cost = cost;
            }

            public override void Move()
            {
                Console.WriteLine("Информация о товаре: \n\tНаименование: {0} \n\tЦена: {1}\n\tПеречень продуктов: {2} \n\tЦена: {3}", Name, cost, list, cost);
            }
            public override void Examination()
            {
                Console.WriteLine("Срок годности не указан");
            }
        }

        static void Main(string[] args)
        {

            Goods[] Good = new Goods[10];
            // Good[0] = new Product(Name = "Шерсть", 0, 12, "12.12.2012", 12);
            Good[0] = new Product("Шерсть", 4, "12.12.2012", 12, 5);
            Good[1] = new Product("Шерсть овцы", 14, "12.12.2012", 12, 12);
            Good[2] = new Product("Шерсть козы", 43, "12.12.2012", 12, 9);
            Good[3] = new Product("Шерсть собаки", 23, "12.12.2012", 12, 18); 
            Good[4] = new Party("Что-то", 13, "12.12.2012", 12, 18);
            Good[5] = new Party("Кто-то", 13, "12.12.2012", 12, 14);
            Good[6] = new Party("Чего-то", 13, "12.12.2012", 12, 15);
            Good[7] = new Kit("Ящик с рыбой", "Фарш, филе, рыбка", 15);
            Good[8] = new Kit("Ящик с мясом", "Фарш, грудка, филе", 14);
            Good[9] = new Kit("Ящик с овощами", "Помидоры, Огурцы, Капуста", 27);


            Array.Sort(Good);

            foreach (Goods Gd in Good)
            {
                Gd.Move();
            }

            Console.ReadKey();
        }
    }
}
