using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_02
{
    class Class_Test
    {
        public Class_Test() { }
        public Class_Test(int i) { }
        public Class_Test(string str) { }

        public int Plus(int x, int y) { return x + y; }
        public int Minus(int x, int y) { return x - y; }

        [MyAttrib("Описание для property1")]
        public string property1
        {
            get { return _property1; }
            set { _property1 = value; }
        }
        private string _property1;

        public int property2 { get; set; }

       [MyAttrib(Description = "Описание для property3")]
        public double property3 { get; private set; }


        public int field1;
        public float field2;
    }
}

