using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки");
            int mintemp = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            int maxtemp = int.Parse(Console.ReadLine());
            int averagetemp = (mintemp + maxtemp) / 2;
            Console.WriteLine($"Средняя температура за сутки {averagetemp} градусов");
            Console.ReadKey();
        }
    }
}
