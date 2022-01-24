using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашка1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Как Вас зовут?");

            var name = Console.ReadLine();

            var currentdate = DateTime.Now;

            Console.WriteLine($"Привет {name} сегодня {currentdate}"); 

        }
    }
}
