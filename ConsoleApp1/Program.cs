using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    public class Program
    {
        public Program(double[] _items)
        {
            _items = new double[10];
        }

        public static void Main(string[] args)
        {

            // 1st program date time tracker

            // printing the current timezone's time 

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);

            // printing the calculated time 

            DateTime exitDate = new DateTime(2021, 12, 11);
            Console.WriteLine(exitDate);

            // adding some days to the time and printing it

            DateTime startDate = dateTime.AddDays(15);
            Console.WriteLine(startDate);

            // IsDaylightSavingTime(DateTimeOffset) Indicates whether a specified date and time falls in the range
            // of daylight saving time for the time zone of the current TimeZoneInfo object.

            bool areWeInDst = dateTime.IsDaylightSavingTime();
            Console.WriteLine(areWeInDst);


            // converting the date and time to long string  

            Console.WriteLine(dateTime.ToLongDateString());


            // converting the date and time to short string

            Console.WriteLine(dateTime.ToShortTimeString());


            // 2nd program converting the data types like long and int

            int a = 123456789;
            // changing datatype from int to long
            long l = a;

            double d = 123456789.0;
            // changing datatype from double to int
            int b = (int)d;

            double c = 12345.0;
            // changing datatype from double to int by using typeof
            int e = (int)Convert.ChangeType(d, typeof(int));

            // printing the converted datatypes
            Console.WriteLine(l);
            Console.WriteLine(b);
            Console.WriteLine(e);


            // 3rd program substring

            // strings defining the first name and the last names

            string firstName = "Ishansi";
            string lastName = "Agrawal";

            // string cocatenating the two strings by their alloted values

            string fullName = firstName + lastName;

            // creating a substring from index positions locations

            string substring = fullName.Substring(1, 3);
            // printing the particular selected characters of the substring
            Console.WriteLine("Characters 2 to 4 of fullname are" + substring);



            // printing using curly braces and using the value allotment

            string nameUsingInterpolation = $"{firstName}-{lastName}";
            Console.WriteLine(nameUsingInterpolation);

            int n = 2;
            switch (n)
            {
                case >= 1 and < 60:
                    Console.WriteLine("Grade is A");
                    break;

                case >= 60 and < 100:
                    Console.WriteLine("Grade is B");
                    break;

                case >= 100:
                    Console.WriteLine("Grade is C");
                    break;

                default:
                    Console.WriteLine("Grade is D");
                    break;
            }

           
            
            void Push(double item, ref double[] _items, int _currentIndex = -1)
            {
                _items[_currentIndex++] = item;
            }

            Gen.Add<string>("", "");
        }
    }
}