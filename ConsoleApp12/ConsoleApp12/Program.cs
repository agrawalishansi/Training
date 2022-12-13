using System;

namespace ConsoleApp12;
class Program
{

    static void Main(string[] args)
    {
        var sum = 0;
        int[] array1 = { 1, 3, 15, 45, 9 };
        int n = array1.Length;

        for (int i = 0; i < n; i++)
        {
            if (array1[i] % 3 == 0 && array1[i] % 5 == 0)
            {
                sum += array1[i];
            }
            Console.WriteLine(sum);

        }

        

//        List<int> myList = new List<int>() {
//   1,
//   3,
//            15,
//            45,
//};
//        int n = myList.Count;
//        for (int i = 0; i < n; i++)
//        {
//            if (myList[i] % 3 == 0 && myList[i] % 5 == 0)
//            {
//                sum += myList[i];
//            }
//        }

//        Console.WriteLine(sum);

    }
}