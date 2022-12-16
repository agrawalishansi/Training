using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    static class Class2
    {
        public static void Func3(this Class1 p)
        {
            Console.WriteLine("this is third function");
        }
    }
}
