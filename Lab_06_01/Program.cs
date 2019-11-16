using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_01
{
    delegate string MaxOrMin(string st1, string st2);
    class Program
    {
        static string Max(string st1, string st2)
        {
            if (st1.Length > st2.Length)
                return st1;
            else return st2;
        }

        static string Min(string st1, string st2)
        {
            if (st1.Length < st2.Length)
                return st1;
            else return st2;
        }

        static void LongestOrShortest (string way, string word1,  string word2, MaxOrMin Fnk)
        {
            Console.WriteLine(way + Fnk(word1, word2));
        }

        static void LongestOrShortestFunc(string str1, string str2, Func<string, string, string> Fnk)
        {
            Console.WriteLine("Длинее:"+ Fnk(str1, str2));
        }
        static void Main(string[] args)
        {
            string w1 = "Dad";
            string w2 = "Father";

            //Создание экземпляра делегата на основе метода
            Console.WriteLine("На основе метода:");
            MaxOrMin f1 = new MaxOrMin(Max);
            LongestOrShortest("Длиннее: ", w1, w2, f1);

            MaxOrMin f2 = Min;
            LongestOrShortest("Короче: ", w1, w2, f2);

            //Использование лямбда-выражение
            Console.WriteLine("\nИспользование лямбда-выражение:");
            LongestOrShortest("Длиннее: ", "Mother", "Mom",
                (string str1, string str2) =>
                {
                    if (str1.Length > str2.Length)
                        return str1;
                    else return str2;
                }
                );


            //Использование Func
            Console.WriteLine("\nBльзование Func:");
            LongestOrShortestFunc("Func", "Function", Max);

            //Использование Action
            Console.WriteLine("\nИспользование Action:");
            Action<string, string> a = (str1, str2) =>
            {
                if (str1.Length < str2.Length)
                    Console.WriteLine("Короче:" + str1);
                else Console.WriteLine("Короче:" + str2);
            };
            a("Action", "Act");


            Console.ReadLine();

        }
    }
}
