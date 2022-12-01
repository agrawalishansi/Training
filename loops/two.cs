using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    public static class two
    {
        static int number = 20;

        public static void SwitchCases()
        {
            switch (number)
            {

                case 5:
                    Console.WriteLine("case 5");
                    break;
                case 10:
                    Console.WriteLine("case 10");
                    break;
                case 20:
                    Console.WriteLine("case 20");

                    // goto statement transfer
                    // the control to case 5
                    goto case 5;

                default:
                    Console.WriteLine("No match found");
                    break;

            }
        }

        public static void PrintValues() 
        {
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
                }
            }

            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else
            {
                Console.WriteLine("x is less than y");
            }

            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine("the for loop conditioning" + k);
            }
        }
        
        public static void PrintSecond()
        {
            int monthlyWage = 1234;
            int months = 12, bonus = 1000;

            bool isActive = true;
            double cating = 99.25;

            // bye numberOfEmployees = 300;
            double ratePerHour = 12.34;
            int numberOfHoursWorked = 165;

            double currentMonthWage = ratePerHour + numberOfHoursWorked + bonus;
            Console.WriteLine(currentMonthWage);

            ratePerHour += 3;// ratePerHour = ratePerHour +3

            if (currentMonthWage > 2000)
            {
                Console.WriteLine("top paid employee");
            }

            int numberOfEmployees = 15;
            numberOfEmployees--;

            char myChar = 'a';
            bool isWhiteSpace = char.IsWhiteSpace(myChar);
            Console.WriteLine(isWhiteSpace);
            bool isDigit = char.IsDigit(myChar);
            Console.WriteLine(isDigit);
            bool isPunctuation = char.IsPunctuation(myChar);
            Console.WriteLine(isPunctuation);



            // cocatenating the string 
            string employeeName = "Bethany";
            int age = 34;
            string greetingText = "hello " + employeeName + " you are " + age + "years";
            Console.WriteLine(greetingText);

            int num = 2;
            int result = One.Addition(num);
            Console.WriteLine("the addition is {0}", result);

            
        }
}
}
