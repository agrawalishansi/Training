using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        // Part 1: declare 2 collections of int elements.
        int[] array1 = { 1, 1, 2 };
        List<int> list1 = new List<int>() { 1, 1, 2 };

        // Part 2: use Sum extension on their elements.
        int sum1 = array1.Sum();
        int sum2 = list1.Sum();

        // Part 3: write results to screen.
        Console.WriteLine("SUM: {0}", sum1);
        Console.WriteLine("SUM: {0}", sum2);


        int[] array2 = { 3, 4, 5 };
        List<int> list2 = new List<int>() { 4, 5, 6 };
        int sum3 = array2.Sum();
        int sum4 = list2.Sum();

        Console.WriteLine("Sum : {0}", sum3);
        Console.WriteLine("Sum: {0}" ,sum4);
    }
}