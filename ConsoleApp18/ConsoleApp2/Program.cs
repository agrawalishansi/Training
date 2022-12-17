using System;
namespace ConsoleApp2;
public class Program
{
    public static bool IsPalindrome(string value)
    {
        int x = 0;
        

        int y = value.Length - 1;
        while (true)
        {
            if (x > y)
            {
                return true;
            }
            char i = value[x];
            char j = value[y];
            // Scan forward for a while invalid.
            while (!char.IsLetterOrDigit(i))
               
            {
                x++;
                if (x > y)
                {
                    return true;
                }
                i = value[x];
            }
            while (!char.IsLetterOrDigit(j))
            {
                y--;
                if (x > y)
                {
                    return true;
                }
                j = value[y];
            }
            if (char.ToLower(i) != char.ToLower(j))
            {
                return false;
            }
            x++;
            y--;
        }
    }
    public static void Main(string[] args)
    {
        string[] ary =
        {
"Was it a car or a cat I saw?"
};
        foreach (string value in ary)
        {
            Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
        }
    }
}