using System;
namespace ConsoleApp4;
public class Program
{
    //To find all the subsets of a string
    static void subString(String str)

    {
        int n = str.Length;

        for (int i = 0; i < n; i++) //To select the starting index
        {
            for (int j = 0; j <= n - i; j++) //To select the ending index
            {
                Console.WriteLine(str.Substring(i, j));
            }
        }
    }
    // Driver program to test above function
    static public void Main()
    {
        String str = "Hello";
        Console.WriteLine("The entered string are " + str);
        Console.WriteLine("All the substrings of the above string is: ");
        //Call to find the all the subsets of the string
        subString(str);
    }
}