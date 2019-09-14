﻿using System;
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
            string answ = "y";
            while (answ == "y")
            {
                Console.WriteLine("Введите значение первого коэффициента:");
                string a = Console.ReadLine();
                while (Double.TryParse(a, out A) == false)
                {
                    Console.WriteLine("Некорректный ввод. Повторите: ");
                    a = Console.ReadLine();
                }
                Console.WriteLine("Введите значение второго коэффициента:");
                string b = Console.ReadLine();
                while (Double.TryParse(b, out B) == false)
                {
                    Console.WriteLine("Некорректный ввод. Повторите: ");
                    b = Console.ReadLine();
                }
                Console.WriteLine("Введите значение третьего коэффициента:");
                string c = Console.ReadLine();
                while (Double.TryParse(c, out C) == false)
                {
                    Console.WriteLine("Некорректный ввод. Повторите: ");
                    c = Console.ReadLine();
                }
                if ((A == 0) && (B == 0) && (C == 0))
                    Console.WriteLine("Корень уравнения - любое число.");
                else if ((C != 0) && (B == 0) && (A == 0))
                    Console.WriteLine("Нет решений.");
                else
                {
                    double D = B * B - 4 * A * C;
                    if (D < 0)
                    {
                        Console.WriteLine("Дискрименант меньше нуля. Для повтора ввода введите 'y'");
                        answ = Console.ReadLine();
                    }
                    else
                    {
                        double X = ((-1 * B) - Math.Sqrt(D)) / (2 * A);
                        double Y = ((-1 * B) + Math.Sqrt(D)) / (2 * A);
                        if ((X < 0) && (Y < 0))
                        {
                            Console.WriteLine("Уравнение не имеет рациональных корней. Для повтора ввода введите 'y'");
                            answ = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Корни уравнения:");
                            if (X > 0)
                            {
                                double X_1 = Math.Sqrt(X);
                                double X_2 = -1 * X_1;
                                Console.WriteLine("{0} {1}", X_1, X_2);
                            }
                            else if (X == 0)
                                Console.WriteLine(X);
                            if ((Y > 0) && (X != Y))
                            {
                                double Y_1 = Math.Sqrt(Y);
                                double Y_2 = -1 * Y_1;
                                Console.WriteLine("{0} {1}", Y_1, Y_2);
                            }
                            else if ((Y == 0) && (X != Y))
                                Console.WriteLine(Y);
                            Console.WriteLine("Для повтора ввода введите 'y'");
                            answ = Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
