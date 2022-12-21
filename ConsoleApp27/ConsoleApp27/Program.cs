using System;
namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {

            double? pi = 3.14;

            char? letter = 'a';

            int m2 = 10;

            int? m = m2;

            bool? flag = null;

            int?[] arr = new int?[10];

            int? a = 42;

            if(a is int valueOfA)

            {

                Console.WriteLine($"a is {valueOfA}");
           
            }

            else
            
            {

                Console.WriteLine("a does not have a value");
            
            }

            if (a.HasValue)
            
            {
               
                Console.WriteLine($"a is {a.Value}");
            
            }

            else
            
            {
               
                Console.WriteLine("a does not have a value");
            
            }

            int? f = 7;

            if (f != null)
            
            {

                Console.WriteLine($"f is {f.Value}");
            
            }
            
            else
            
            {

                Console.WriteLine("f does not have a value");
            
            }

            int? c = 28;

            int b = c ?? -1;

            Console.WriteLine($"b is {b}"); 

            int? e = null;

            int d = e ?? -1;

            Console.WriteLine($"d is {d}");

            int? n = null;

            //int m1 = n;   
            
            // Doesn't compile

            int n2 = (int)n;

            // Compiles, but throws an exception if n is null

            int? a2 = 10;

            int? b2 = null;

            int? c2 = 10;

            a++;        
            
            // a is 11
            
            
        
        }
    }
}