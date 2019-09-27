using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scnd
{
    //....Абстрактный класс Геометрическая фигура....
    public abstract class Geom_Figure: IComparable
    {
        public abstract double Area();
        public abstract int CompareTo(object obj);

    };
}
