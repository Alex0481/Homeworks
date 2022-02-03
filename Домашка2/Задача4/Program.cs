using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Это я не успевал и честно слямзил у коллег, простите)

            string nazvaniekursa = "1. GEEK UNIVERSITY разработки на С# ";
            string kassir = "Иванова";
            string shopname = "ООО GeekBrains";
            double summapokupki = 110000.01;
            int nomercheka = 145777;
            int kkmchislo = 180000000;
            int innchiclo = 770000000;
            int nomerchekatoday = 800;
            DateTime vremya = DateTime.Today;

            Console.WriteLine("------------------------------------");
            Console.WriteLine($"-----------{shopname}-----------");
            Console.WriteLine($"------------Чек N{nomercheka}-------------");
            Console.WriteLine($"--------------{kassir}---------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"{nazvaniekursa}");
            Console.WriteLine($"Стоимость------------------{summapokupki}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Всего----------------------{summapokupki}");
            Console.WriteLine($"ККМ{kkmchislo}------ИНН{innchiclo}------");
            Console.WriteLine($"{vremya}-----------{kassir}");
            Console.WriteLine($"Продажа--------------------------{nomerchekatoday}");
            Console.WriteLine($"Итог-----------------------{summapokupki}");
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
        }
    }
}
