using System;
using System.Net;
using System.Linq;
using System;

namespace ConsoleApp23
{

class Program
{
    public static void Main(string[] args)
    {
        // sequence equal method
        bool value;
        // Create a list of numbers
        List<int> list1 = new() { 5, 2, 3, 4, 5 };
        // Create a list of numbers
        List<int> list2 = new() { 1, 2, 3, 4, 5 };

        // Write Query Syntax Here
        value = (from num in list1
                 select num)
                 .SequenceEqual(list2);

         Console.WriteLine(value);


        // except qwuery
        List<int> list;
        // Create a list of numbers
        List<int> list3 = new() { 5, 2, 3, 4, 5 };
        // Create a list of numbers
        List<int> list4 = new() { 3, 4, 5 };

        // Write Query Syntax Here
        list = (from num in list3
                select num)
                .Except(list4).ToList();

        Console.WriteLine(list);

        // intersect method

        
            List<int> list5;
            // Create a list of numbers
            List<int> list6 = new() { 5, 2, 3, 4, 5 };
            // Create a list of numbers
            List<int> list7 = new() { 3, 4, 5 };

            // Write Query Syntax Here
            list5 = (from num in list6
                    select num)
                    .Intersect(list7).ToList();

            Console.WriteLine(list5);


        // union and then orderBy
        
            List<int> list8;
            // Create a list of numbers
            List<int> list9 = new() { 5, 2, 3, 4, 5 };
            // Create a list of numbers
            List<int> list10 = new() { 1, 2, 3, 4, 5 };

            // Write Query Syntax Here
            list8 = (from num in list9
                    select num)
                    .Union(list10)
                    .OrderBy(num => num).ToList();

            Console.WriteLine( list8);


        //concat and then order by
        /// </summary>
       
            List<int> list11;
            // Create a list of numbers
            
            list11 = (from num in list9
                    select num)
                    .Concat(list10)
                    .OrderBy(num => num).ToList();

            Console.WriteLine(list11);

        
        }
}
}