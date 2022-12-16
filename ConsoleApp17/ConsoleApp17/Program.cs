
// take two list input from user of same size 
// create another list using both list by adding numbers from one list from begin and another from end
// and find sum of that list

using System;
namespace ConsoleApp17
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            var list = new List<int>();
            var list2 = new List<int>();
            var list3 = new List<int>();
            var sum = 0;
            Console.WriteLine("number of elements ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < n; j++)

            {
                Console.Write("element in list 1 : {0} ", j + 1);
                int v = Convert.ToInt32(Console.ReadLine());
                list.Add(v);


            }


            for (int k = 0; k < n; k++)

            {
                Console.Write("elementin list 2 : {0} ", k + 1);
                int w = Convert.ToInt32(Console.ReadLine());

                list2.Add(w);

            }

            Console.Write("list contains {0} elements: ", list.Count);

            Displaylist(list);

            Console.Write("list2 contains {0} elements: ", list2.Count);
            Displaylist(list2);



            for (int i = 0; i < n; i++)
            {
                list3.Add(list[n- i - 1] + list2[i]);
            }


            Console.Write("list3 contains {0} elements: ", list3.Count);

            Displaylist(list3);

            foreach (var item in list3)
            {

                sum += item;

            }

            Console.WriteLine("sum of elements in list 3 is");
            Console.WriteLine(sum);
        }

            static void Displaylist(List<int> collection)
        {
            Console.Write("{");
            foreach (int i in collection)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }




    }

}
    
