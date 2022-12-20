using System;
namespace ConsoleApp2;

static class Program
{
    public static void Main(string[] args)
    {// take
        IList<string> list = new List<string>() { "one", "two", "three", "four", "five"};
        var newList = list.Take(2);

        foreach(var str in newList)
            Console.WriteLine(str);
        // takewhile
        IList<string> strList = new List<string>() {
                                            "Three",
                                            "Four",
                                            "Five",
                                            "Hundred"  };

        var result = strList.TakeWhile(s => s.Length > 4);

        foreach (string str in result)
            Console.WriteLine(str);

        // skip
        var list2 = list.Skip(2);
        foreach(var str2 in list2)
            Console.WriteLine(str2);



        // skip while
        var resultList = strList.SkipWhile(s => s.Length < 4);
        foreach (string str in resultList)
            Console.WriteLine(str);

        // distinct
        List<int> intCollection = new List<int>()
        {
            1,2,3,2,3,4,4,5,6,3,4,5
        };
        var MS = intCollection.Distinct();
        var QS = (from num in intCollection
                  select num).Distinct();
        foreach (var item in MS)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();


        //chunk
        int chunkNumber = 1;
        foreach (int[] chunk in Enumerable.Range(0,8).Chunk(3))
        {
            Console.WriteLine($"Chunk {chunkNumber++}:");
            foreach (int item in chunk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();




            // distinctBy
            var MS2 = intCollection.DistinctBy(num => num > 2);
            foreach (var item in MS2)
            {
                Console.WriteLine("distinct by",item);
            }
            Console.ReadKey();




            // distinct.OrderBy
            var MS3 = intCollection.Distinct().OrderBy(c => c).ToList();
            foreach (var item in MS3)
            {
                Console.WriteLine("distinct order by",item);
            }
            Console.ReadKey();



            // contains
            
                List<int> numbers = new() { 1, 2, 3, 4, 5 };
                bool value;
            bool value2;
                value = (from num in numbers
                         select num).Contains(3);

                 Console.WriteLine("contains",value);


            // .All method
            value2 = (from prod in numbers
                     select prod)
               .All(prod => prod > 3);
            Console.WriteLine(".All method",value2);


        }


    }


}
