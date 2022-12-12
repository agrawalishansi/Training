using System;
namespace ConsoleApp1
{
    class Program
    {

        public static void Add<T>(T value)
        {
            var set = new HashSet<T>();
        }
     
        public static void Main(String[] args)
        {
            var set = new HashSet<string>();

            set.Add("a");
            set.Add("b");   
            set.Add("c");
            set.Add("a");

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

        }
    }
}