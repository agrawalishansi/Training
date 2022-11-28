using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using ISHANSI;
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
        public static bool b3 = string.IsNullOrEmpty(str1);
        //String.Join();

        public static string charsStr2 = new string(new char[]
    {'i','a','b','u','s','y','i','n','o','f','f','i','c','e','m','e','s','s','a','g','e','m','e','l','a','t','e','r'});
         


        //String.Length;
        //trim(), trimStart, trimEnd 
        // String.IsNullOrWhiteSpace()
        // name.ToCharArray();

    }
    

}

