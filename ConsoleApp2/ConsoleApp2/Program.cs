using System;
namespace ConsoleApp2;
// program to multiply two strings 
public class Program
{

    public static void Main(string[] args)
    {

        string applesInBasket = "16";
        string baskets = "4";
        int total = Convert.ToInt32(applesInBasket) * Convert.ToInt32(baskets);
        string msg = $"There are total of {total} apples";
        Console.WriteLine(msg);


    }
}
