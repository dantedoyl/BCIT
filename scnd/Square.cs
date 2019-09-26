﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scnd
{
    //...Класс Квадрат...
    public class Square : Rectangle, IPrint
    {
        public Square(double a) : base(a, a)
        {
            lngth = a;
            wdth = a;
        }

        public override string ToString()
        {
            return "Длина стороны: " + lngth.ToString() + '\n' + "Площадь: " + Area().ToString() + '\n';
        }

        public new void Print()
        {
            Console.WriteLine("Квадрат:\n" + ToString());
        }
    }
}
