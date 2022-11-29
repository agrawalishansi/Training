using FakeItEasy;
using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;





namespace ishansiinteger
{
    public class Program
    {
        public static void Main(string[] args)

        {
            int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // foreach loop begin
            // it will run till the
            // last element of the array
            foreach (int items in a_array)
            {
                Console.WriteLine(items);
            }



            // while loop
            int x = 1;

            // Exit when x becomes greater than 4
            while (x <= 4)
            {
                Console.WriteLine("software developer");

                // Increment the value of x for
                // next iteration
                x++;
            }



            // do while loop
            int y = 21;
            do
            {
                // The line will be printed even
                // if the condition is false
                Console.WriteLine("c sharp");
                y++;
            }
            while (y < 20);


            // nested loop
            for (int i = 2; i < 3; i++)
                for (int j = 1; j < i; j++)
                    Console.WriteLine("nested loop");



            // continue statement
            for (int i = 1; i < 3; i++)
            {
                if (i == 2)
                    continue;

                Console.WriteLine("continue statement");
            }
        }  
    }
}