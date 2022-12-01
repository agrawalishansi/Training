
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System;
using System.Security.Cryptography.X509Certificates;

namespace loops
{
    public class Program
    {
    
        public static void Main(string[] args)
        {
            One.displaysubject("Subject");
            One.Addition(5);
            One.Add(1,2,34,5);


            two.PrintValues();
            two.PrintSecond();



            // working with optional parameters
           int AddNumbers(int a, int b, int c = 100)
            {
                int sum = a + b + c;
                return sum;
            }
            Console.WriteLine(AddNumbers(1, 2, 3));
            Console.WriteLine(AddNumbers(a: 20, b: 40));

        }

            
    }
 }