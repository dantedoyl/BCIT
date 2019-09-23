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
            Console.Title = "Торжков Максим ИУ5-31Б";
            double a, b, c;
            string str_a, str_b, str_c;
            string answ = "y";
            while (answ == "y")
            {
                if ((args != null)&&(args.Length>=1))
                {
                    str_a = args[0];
                }
                else
                {
                    Console.WriteLine("Введите значение первого коэффициента:");
                    str_a = Console.ReadLine();
                }
                while (Double.TryParse(str_a, out a) == false)
                {
                    Console.WriteLine("Некорректный ввод. Повторите: ");
                    str_a = Console.ReadLine();
                }
                if ((args != null)&& (args.Length >= 2)) {
                    str_b = args[1];
                }
                else
                {
                    Console.WriteLine("Введите значение второго коэффициента:");
                    str_b = Console.ReadLine();
                }
                while (Double.TryParse(str_b, out b) == false)
                {
                    Console.WriteLine("Некорректный ввод. Повторите: ");
                    str_b = Console.ReadLine();
                }
                if ((args != null)&& (args.Length >= 3)) {
                    str_c = args[2];
                }
                else
                {
                    Console.WriteLine("Введите значение третьего коэффициента:");
                    str_c = Console.ReadLine();
                }
                while (Double.TryParse(str_c, out c) == false)
                {
                    Console.WriteLine("Некорректный ввод. Повторите: ");
                    str_c = Console.ReadLine();
                }


                if ((a == 0) && (b == 0) && (c == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корень уравнения - любое число.\nДля повторного ввода введите 'y'");
                    answ = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if ((c != 0) && (b == 0) && (a == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нет решений.\nДля повторного ввода введите 'y'");
                    answ = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if ((b!= 0) && (a == 0))
                {
                    double x = -c / b;
                    if (x < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Уравнение не имеет рациональных корней. Для повтора ввода введите 'y'");
                        answ = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (x == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения:\n0");
                        Console.WriteLine("Для повтора ввода введите 'y'");
                        answ = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения:\n{0}\n{1}", Math.Sqrt(x), -Math.Sqrt(x));
                        Console.WriteLine("Для повтора ввода введите 'y'");
                        answ = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    double d = b * b - 4 * a * c;
                    if (d < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Дискрименант меньше нуля. Уравнение не имеет рациональных корней. Для повтора ввода введите 'y'");
                        answ = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        double x = ((-1 * b) - Math.Sqrt(d)) / (2 * a);
                        double y = ((-1 * b) + Math.Sqrt(d)) / (2 * a);
                        if ((x < 0) && (y < 0))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Уравнение не имеет рациональных корней. Для повтора ввода введите 'y'");
                            answ = Console.ReadLine();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Корни уравнения:");
                            if (x > 0)
                            {
                                double x_1 = Math.Sqrt(x);
                                double x_2 = -1 * x_1;
                                Console.WriteLine("{0} {1}", x_1, x_2);
                            }
                            else if (x == 0)
                                Console.WriteLine(x);
                            if ((y > 0) && (x != y))
                            {
                                double y_1 = Math.Sqrt(y);
                                double y_2 = -1 * y_1;
                                Console.WriteLine("{0} {1}", y_1, y_2);
                            }
                            else if ((y == 0) && (x != y))
                                Console.WriteLine(y);
                            Console.WriteLine("Для повтора ввода введите 'y'");
                            answ = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                args = null;
               // Array.Clear(args, 0, args.Length);
                }
            }
            
        }
    }

