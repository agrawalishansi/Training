
using System;

namespace ConsoleApp41
{

    public class Program6
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Bethany's Pie Shop HRM");


            int amount = 1234;
            int months = 12;
            int bonus = 1000;

            int yearlyWage = Utilities2.CalculateYearlyWage(amount, months);
            int yearlyWageWithBonus = Utilities2.CalculateYearlyWage(amount, months, bonus);

            Console.WriteLine($"Yearly wage: {yearlyWage}");


            double amountDouble = 1500.0;
            double monthsDouble = 12;
            double bonusDouble = 1000;

            double yearlyWageWithBonusDouble = Utilities2.CalculateYearlyWage(amountDouble, monthsDouble, bonusDouble);

            Utilities2.UsingOptionalParameters();

            Utilities2.UsingNamedArguments();

            Utilities2.ManipulatingStrings();

            Utilities2.UsingEscapeCharacters();

            Utilities2.UsingStringEquality();

            Utilities2.ParsingStrings();



            Console.ReadLine();

        }
    }
}
