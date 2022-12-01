using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Gen
    {
        public static void Add<T>(T value1, T value2)
        {
            Console.WriteLine(value2+ " " + value1);
        } 
    }
}
