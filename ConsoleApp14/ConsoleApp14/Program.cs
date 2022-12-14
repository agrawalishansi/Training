using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp14;
class Program
{
    static void Main(string[] args)
    {




        //HashSet<int> evenNumbers = new HashSet<int>();
        //HashSet<int> oddNumbers = new HashSet<int>();

        //for (int i = 0; i < 5; i++)
        //{
        //    // Populate numbers with just even numbers.
        //    evenNumbers.Add(i * 2);

        //    // Populate oddNumbers with just odd numbers.
        //    oddNumbers.Add((i * 2) + 1);
        //}

        //Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
        //DisplaySet(evenNumbers);

        //Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
        //DisplaySet(oddNumbers);

        //// Create a new HashSet populated with even numbers.
        //HashSet<int> numbers = new HashSet<int>(evenNumbers);
        //Console.WriteLine("numbers UnionWith oddNumbers...");
        //numbers.UnionWith(oddNumbers);

        //Console.Write("numbers contains {0} elements: ", numbers.Count);
        //DisplaySet(numbers);

        //void DisplaySet(HashSet<int> collection)
        //{
        //    Console.Write("{");
        //    foreach (int i in collection)
        //    {
        //        Console.Write(" {0}", i);
        //    }
        //    Console.WriteLine(" }");
        //}


        int a ;
        int firstmax = 0;
        int secondmax = 0;
        Console.WriteLine("the value of a is:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a);
        
        var b = new HashSet<int>();
        for(int i=0; i < a;i++) 
        {
            Console.WriteLine("values are:");
            int j = Convert.ToInt32(Console.ReadLine());
            b.Add(j);
        }
        greatest(b);

        
        void greatest(HashSet<int> collection)
        {
            foreach (int j in collection)
            {
                if (j > firstmax)
                {
                    secondmax = firstmax;
                    firstmax = j;
                    
                }

            }
            
            Console.WriteLine("first max value in b is ");
            Console.WriteLine(firstmax);
            Console.Write("second max value in b is ");
            Console.WriteLine(secondmax);


        }

    }
}