using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frst
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            Console.WriteLine("Введите значение первого коэффициента:");
            string a = Console.ReadLine();
            while (Double.TryParse(a, out A) == false)
            {
                Console.WriteLine("Некорректный ввод. Повторите: ");
                a = Console.ReadLine();
            }

            }
    }
}
