using System;
using System.Net;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
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
            List<int> list2 = new() { 5, 2, 3, 4, 5 };

            // Write Query Syntax Here
            value = (from num in list1
                     select num)
                     .SequenceEqual(list2);
            Console.WriteLine("sequence equal method");
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
            Console.WriteLine("except query method");
            displayList(list);

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
            Console.WriteLine("intersect query method");
            displayList(list5);


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
            Console.WriteLine("Union and then order by method in linq");
            displayList(list8);


            //concat and then order by
            /// </summary>

            List<int> list11;
            // Create a list of numbers

            list11 = (from num in list9
                      select num)
                    .Concat(list10)
                    .OrderBy(num => num).ToList();
            Console.WriteLine("Concat and then order by method in linq ");
            displayList(list11);

            void displayList(List<int> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            // groupBY use
            // lamda expression
            //var groups = people.GroupBy(x => x.Forename);
            //QUERY EXPRESSION

            List<Person> people = new List<Person>()
        {
            new Person() { Forename = "John", Surname = "Smith", Age = 33 },
            new Person() { Forename = "Michael", Surname = "Jones", Age = 41 },
            new Person() { Forename = "Susan", Surname = "Taylor", Age = 21 },
            new Person() { Forename = "Michael", Surname = "Evans", Age = 41 },
            new Person() { Forename = "James", Surname = "Wilson", Age = 39 },
            new Person() { Forename = "Michael", Surname = "Johnson", Age = 35 },
            new Person() { Forename = "Susan", Surname = "Davies", Age = 21 },
            new Person() { Forename = "Susan", Surname = "Robinson", Age = 47 },
            new Person() { Forename = "John", Surname = "Wright", Age = 44 },
            new Person() { Forename = "Susan", Surname = "Walker", Age = 21 }

        };
            var groups = from p in people
                         group p by p.Forename;

            foreach (var group in groups)
            {
                Console.WriteLine("GroupBy function use");
                Console.WriteLine($"Group key: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($"Forename: {person.Forename}, Surname: {person.Surname}, Age: {person.Age}");
                }
                Console.WriteLine();

            }

            // MaxBy
            var animalCountMap = new Dictionary<string, string>()
            {
                ["fish"] = "100",
                ["dog"] = "3",
                ["cat"] = "10",
                ["bird"] = "50"
            };

            var maxKVP = animalCountMap.MaxBy(kvp => kvp.Value);
            // min By
            var maxKVP2 = animalCountMap.MinBy(kvp => kvp.Value);
            var animal = maxKVP.Key;
            var count = maxKVP.Value;
            var animal2 = maxKVP2.Key;
            var count2 = maxKVP2.Value;
            Console.WriteLine("MaxBy use");
            
            Console.WriteLine($"Animal seen the most: {animal} ({count})");

            Console.WriteLine("MinBy value");
            Console.WriteLine($"Animal seen the least: {animal2} ({count2})");

            // use of filtering by where clause in linq
            
             var subList = animalCountMap.Where(p => p.Key == "cat" || p.Value == "10");
            
            Console.WriteLine("filtering");
            
            Console.WriteLine($"{subList.Count()} animal match your search criteria:");



            // select many
                List<string> nameList = new List<string>() { "ishansi", "agrawal" };
                IEnumerable<char> methodSyntax = nameList.SelectMany(x => x);
            Console.WriteLine("Select many function in linq in c#");
            foreach (char c in methodSyntax)
                {
                
                    Console.Write(c + " ");
                }

            


}
    }
}
