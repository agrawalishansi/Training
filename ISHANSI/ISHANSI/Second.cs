using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISHANSI
{
    public static class Second
    {
        public static string name = "IShanshi";
       static string str1 = "Pro";
        static string str2 = "Pro";
        static object[] array = { "Hello", "Geeks", 12345, 786 };

        // Using Join method
        // Here separator is ', '( comma )
        public static string s1 = string.Join(", ", array);

        // Finally after joining process gets over
        // Getting the output of value of string s1

       public  static string str = "    h    i";


        //The Trim method removes all leading and trailing white-space characters from the current string object.

        

        // for whitespace value always return true
         public static bool b2 = string.IsNullOrWhiteSpace(str1);
       


        //String.Join();
        //String.Length;
        //trim(), trimStart, trimEnd 
        // String.IsNullOrWhiteSpace()
        //    name.ToCharArray();

    }
}
