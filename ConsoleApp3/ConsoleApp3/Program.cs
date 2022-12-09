using System;
namespace ConsoleApp3;
public class Program
{
    //To find all the subsets of a string
    static void subString(String str)

    {
        int n = str.Length;
        string[] array= new string[n];
        for (int i = 0; i < n; i++) //To select the starting index
        {
            array[i] = str.Substring(0, i + 1);
                Console.WriteLine(array[i]);
            
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