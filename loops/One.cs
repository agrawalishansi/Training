using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    public static class One
    {
        // try catch block
        // taking null in the string
        

        // method to display subject name   
        public static void displaysubject(string sub1)
        {
            if (sub1 == null)
                Console.WriteLine("Exception Message");

        }


        // addition predefined and then later used in main
        public static int Addition(int a)
        {
            int add = a + a;
            return add;
        }

        // using params
        public static int Add(params int[] ListNumbers)
        {
            int total = 0;
            foreach (int i in ListNumbers)
            {
                total += i;
            }
            return total;
        }
    }
}
