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
        // defining strings and objects initially
        public static string name = "IShanshi";
        static string str1 = "Pro";
        static object[] array = {"Hello" , "Geeks",12345,786};

        // Using Join method
        // Here separator is ', '( comma )
        public static string s1 = string.Join(",",array);

       public  static string str = "    h    i";

        //String.IsNullOrWhiteSpace()
         public static bool b2 = string.IsNullOrWhiteSpace(str1);


        // String.IsNullOrEmpty()
        public static bool b3 = string.IsNullOrEmpty(str1);
        
        
        //String.Join();
        public static string charsStr2 = new string(new char[]
    {'i','a','b','u','s','y','i','n','o','f','f','i','c','e','m','e','s','s','a','g','e','m','e','l','a','t','e','r'});


        // switch break
        

      
    }
}

