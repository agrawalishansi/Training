using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    // reverse words in a string 
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the String:");
            
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            Array.Reverse(a);
            
            Console.WriteLine("Reverse String is:");
            for (int i = 0; i <= a.Length - 1; i++)
            {
                
                Console.Write(a[i] + "" + ' ');
            }
            Console.ReadKey();
        }
    }
}