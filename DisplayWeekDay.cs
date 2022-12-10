// C# program to input weekday number
// print the weekday
using System;
using System.IO;
using System.Text;

namespace DisplayWeekDay
{
	class DisplayWeekDay
	{
		// Main Method
		static void Main(string[] args)
		{
			int weekday;

			// input weekday number
			Console.Write("Enter weekday number (0-6): ");
			weekday = Convert.ToInt32(Console.ReadLine());

			// Using switch case to validate
			switch (weekday)
			{
				case 0:
					Console.WriteLine("It is SUNDAY");
					break;
				case 1:
					Console.WriteLine("It is MONDAY");
					break;
				case 2:
					Console.WriteLine("It is TUESDAY");
					break;
				case 3:
					Console.WriteLine("It is WEDNESDAY");
					break;
				case 4:
					Console.WriteLine("It is THURSDAY");
					break;
				case 5:
					Console.WriteLine("It is FRIDAY");
					break;
				case 6:
					Console.WriteLine("It is SATURDAY");
					break;
				
				// if no case value is matched
				default:
					Console.WriteLine("It is wrong input");
					break;
			}

			
		}
	}
}
