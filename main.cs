using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReflectionTest
{
    class main
    {
        static void Main(string[] args)
        {
            ReflectionTest r = new ReflectionTest();
            r.PrintFields();
            r.PrintFieldValues();
        }
    }
}
