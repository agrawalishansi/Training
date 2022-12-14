using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ConsoleApp15;
public class Program
{

    public static void Main(string[] args)
    {
        //int n;
        //Console.Write("Input the number of elements to be stored in the array :");
        //n = Convert.ToInt32(Console.ReadLine());
        //int[] a = new int[n];
        //int i, sum = 0;

        //Console.Write("Input {0} elements in the array :\n", n);
        //for (i = 0; i < n; i++)
        //{
        //    Console.Write("element - {0} : ", i+1);
        //    a[i] = Convert.ToInt32(Console.ReadLine());
        //    sum += a[i];
        //}



        //Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);



        // take input size of list 
        // take input all element of list 
        // add 2 in every element 
        // find sum of odd numbers



        List<int> oldlist = new List<int>();
        List<int> newlist = new List<int>();
        int n;
        var sum = 0;

        Console.Write("Input the number of elements to be stored in the list :");
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)

        {
            Console.Write("element: {0} ", i + 1);
            int v = Convert.ToInt32(Console.ReadLine());
            oldlist.Add(v);
            newlist.Add(v + 2);

        }


        Console.Write("oldlist contains {0} elements: ", oldlist.Count);

        Displaylist(oldlist);

        Console.Write("newlist contains {0} elements: ", newlist.Count);
        Displaylist(newlist);

        Console.WriteLine("sum of odd elements in newlist is:");

        foreach (var item in newlist)
        {
            if (item % 2 != 0)
            {
                sum += item;
            }
        }

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

