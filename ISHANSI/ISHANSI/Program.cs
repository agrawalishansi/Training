using FakeItEasy;
using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using Xceed.Wpf.Toolkit;

namespace ISHANSI
{
    class Program
    {
        public static void Main(string[] args)
        {
            string Name = "hello";
            string name = "world";
            string result = name.Insert(3, Name);
            result = result.Remove(2);
            result = result.Replace('o', '1');
            result = result.ToUpper();
            result = result.ToLower();
            result = result.PadLeft(15);
            object[] o = { name, result };
            char[] chars = name.ToCharArray();
            var numbers = new int[] { 1, 2, };
            var type = numbers.GetType();
           // Console.WriteLine(type.FullName);
            var sum = 0;
            for ( int i = 0;i< numbers.Length;i++)
            {
                sum += numbers[i];
            }
            //Console.WriteLine(string.Concat(o));
            //Console.WriteLine(chars);
            //Console.WriteLine(sum);
            var pt = new Point { X =30, Y = 12 };
            //Console.WriteLine(pt);
            //Console.WriteLine(pt.ToString());
            for (var n = 0; n < args.Length; n++)
            {
               // Console.WriteLine($"[args{n}] = { args[n]}");
            }
            program2.BirthYear = 1963;
            Console.WriteLine(program2.Generation);
            var neSt = "Hello Hello Hello";
            neSt.Split(" ");
            string str1 = "Pro";
            string str2 = "Pro";
            Console.WriteLine(string.Equals(str1, str2));
            Console.WriteLine("Value of string  s1 is " + Second.s1);
            Console.WriteLine(Second.name);
            Console.WriteLine("String Length: " + Second.str.Length);
            Console.WriteLine("After:");
            Console.WriteLine(Second.str.Trim());
            Console.WriteLine(Second.str.TrimStart(' ', 'h'));
            Console.WriteLine(Second.str.TrimEnd(' ', 'h'));
            Console.WriteLine(Second.b2);
            Console.WriteLine(Second.b3);
            Console.WriteLine("Chars to string: {0}", Second.charsStr2);






            
            Console.WriteLine($"nint.MinValue = {nint.MinValue}");
            Console.WriteLine($"nint.MaxValue = {nint.MaxValue}");
            Console.WriteLine($"nuint.MinValue = {nuint.MinValue}");
            Console.WriteLine($"nuint.MaxValue = {nuint.MaxValue}");

            
        }
    }
    enum Generation { BabyBoomer, GenX, Millenial, GenZ, GenA }
    static class  program2
    {
        public static int BirthYear { get; set; }
        public static Generation Generation
        {
            get
            {
                if ((BirthYear >= 1946) && (BirthYear <= 1964))
                {
                    return Generation.BabyBoomer;
                }
                else if ((BirthYear >= 1965) && (BirthYear <= 1980))
                {
                    return Generation.GenX;
                }
                else if ((BirthYear >= 1981) && (BirthYear <= 1996))
                {
                    return Generation.Millenial;
                }
                else if ((BirthYear >= 1997) && (BirthYear <= 2012))
                {
                    return Generation.GenZ;
                }
                else
                {
                    return Generation.GenA;
                }
            }
        }
        //public static Type Calculator =
        //static member Add (a : double, b : double) = A + b  
    }
}