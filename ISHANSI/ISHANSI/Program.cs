using FakeItEasy;
using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using Xceed.Wpf.Toolkit;

namespace ISHANSI
{
    public class Program
    {
        private static int priceScore;

        public static void Main(string[] args)

        {// defining two strings
            string Name = "hello";
            string name = "world";

            //inserting
            string result = name.Insert(3, Name);

            // removing
            result = result.Remove(2);

            //replacing
            result = result.Replace('o', '1');

            //to upper case
            result = result.ToUpper();

            // to lower case
            result = result.ToLower();

            // padding left
            result = result.PadLeft(15);

            // defining an object
            object[] o = { name, result };

            // conversion
            char[] chars = name.ToCharArray();
            Console.WriteLine(chars);

            var numbers = new int[] { 1, 2, };
            // getting type 
            var type = numbers.GetType();
            Console.WriteLine(type.FullName);

            //do while loop
            do
            {
                System.Console.WriteLine(type.FullName);
                type = type.BaseType;
            }
            while (type != null);




            // calculating sum
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);



            // concating the string
            Console.WriteLine(string.Concat(o));

            
            // converting point to string
            var pt = new Point { X = 30, Y = 12 };
            Console.WriteLine(pt);
            Console.WriteLine(pt.ToString());


            // class program2 code
            program2.BirthYear = 1963;
            Console.WriteLine(program2.Generation);


            // splitting
            var neSt = "Hello Hello Hello";
            Console.WriteLine(neSt.Split(" "));


            // comparing two strings
            string str1 = "Pro";
            string str2 = "Pro";
            Console.WriteLine(string.Equals(str1, str2));


            // joining the strings
            Console.WriteLine("Value of string  s1 is " + Second.s1);
            Console.WriteLine(Second.name);


            // calculating the length of string
            Console.WriteLine("String Length: " + Second.str.Length);
            Console.WriteLine("After:");

            // trimming
            Console.WriteLine(Second.str.Trim());

            // trimStart
            Console.WriteLine(Second.str.TrimStart(' ', 'h'));

            // trimEnd
            Console.WriteLine(Second.str.TrimEnd(' ', 'h'));

            // boolean results
            Console.WriteLine(Second.b2);
            Console.WriteLine(Second.b3);

            // char to string
            Console.WriteLine("Chars to string: {0}", Second.charsStr2);

            // nint and nuint max and min values
            Console.WriteLine($"nint.MinValue = {int.MinValue}");
            Console.WriteLine($"nint.MaxValue = {int.MaxValue}");
            Console.WriteLine($"nuint.MinValue = {uint.MinValue}");
            Console.WriteLine($"nuint.MaxValue = {uint.MaxValue}");


            // how to use the value defined before
            var names = "Dinesh";
            Console.WriteLine($"Name : {names}");


           // will convert the number variable to integer
            var number = "32433";
            var ones = int.Parse(number);
            Console.WriteLine(ones);


            // will try parse and return boolean also will output the number into new variable ones defined above
            int one;
            var results = int.TryParse(number, out one);
            Console.WriteLine(results);
            

            // aggregate of upcoming numbers step by step
            var numberz = new int[] { 1, 2, 3, 4, 5 };
            var sumOfNumbers = numberz.Aggregate(
                0,
                (total, num) =>
                {
                    Console.WriteLine("total = {0}, num = {1}", total, num);
                    return total + num;
                }
                );
            Console.WriteLine(sumOfNumbers);





            // args printing by for loop
            Console.WriteLine("Hello, world");
            for(var n=0; n<args.Length; n++)
            {
                Console.WriteLine($"args[{n}] = {args[n]}");
            }


            //
            switch (priceScore)
            {
                case 1:
                case 2:
                    Console.WriteLine("good");
                    break;

                case 3:
                    Console.WriteLine("Average");
                    break;

                case 4:
                case 5:
                    Console.WriteLine("ok job");
                    break;
            }

        }
    }
    // code for choice of printing by the required range parameter.
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
    }
}