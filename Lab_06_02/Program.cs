﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Lab_06_02
{
    class Program
    {
        /// <summary>
        /// Проверка, что у свойства есть атрибут заданного типа
        /// </summary>
        /// <returns>Значение атрибута</returns>
        public static bool GetPropertyAttribute(PropertyInfo checkType, Type attributeType, out object attribute)
        {
            bool Result = false;
            attribute = null;

            //Поиск атрибутов с заданным типом
            var isAttribute = checkType.GetCustomAttributes(attributeType, false);
            if (isAttribute.Length > 0)
            {
                Result = true;
                attribute = isAttribute[0];
            }

            return Result;
        }
        static void Main(string[] args)
        {
            Type a = typeof(Class_Test);

            Console.WriteLine("Информация о типе: " + a.Name);

            Console.WriteLine("\nКонструкторы:");
            foreach (var x in a.GetConstructors())
                Console.WriteLine(x);

            Console.WriteLine("\nМетоды:");
            foreach (var x in a.GetMethods())
                Console.WriteLine(x);

            Console.WriteLine("\nСвойства:");
            foreach (var x in a.GetProperties())
                Console.WriteLine(x);

            Console.WriteLine("\nПоля данных:");
            foreach (var x in a.GetFields())
                Console.WriteLine(x);

            Console.WriteLine("\nСвойства с атрибутом:");
            foreach(var x in a.GetProperties())
            {
                object attrObj;
                if (GetPropertyAttribute(x, typeof(MyAttrib), out attrObj))
                {
                    MyAttrib attr = attrObj as MyAttrib;
                    Console.WriteLine(x.Name + " - " + attr.Description);
                }
            }

            Class_Test n = new Class_Test();

            object[] arg = { 1, 2 };

            object r = a.InvokeMember("Minus", BindingFlags.InvokeMethod, null, n, arg);
            Console.WriteLine("\nВызов метода Minus: 1-2= " + r.ToString());

            Console.ReadLine();
        }
    }
}
