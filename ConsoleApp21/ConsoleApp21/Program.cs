using System;
using System.Drawing;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp21;
public class Program: IComparer<decimal>
{
    public string Name { get; set; }
    public string Age { get; set; }

    public int Compare(decimal d1, decimal d2)
    {
        decimal fractional1, fractional2;
        try
        {
            fractional1 = decimal.Remainder(d1, decimal.Floor(d1));

        }
        catch (DivideByZeroException) { fractional1 = d1; }

        try
        {
            fractional2 = decimal.Remainder(d2, decimal.Floor(d2));

        }
        catch (DivideByZeroException) { fractional2 = d2; }

        if (fractional1 == fractional2)
            return Decimal.Compare(d1, d2);
        else if (fractional1 > fractional2)
            return 1;
        else
            return - 1;


    }


    public static void Main(string[] args)
    {







        string[] names = { "hartono, tommy", "adams, terry", "andersen, herriette thaulow", "hedlund magnus", "ito, shu" };
        string firstLongName = names.FirstOrDefault(name => name.Length > 20);
        Console.WriteLine("the first long name is '{0}'", firstLongName);
        string firstVeryLongName = names.FirstOrDefault(name => name.Length > 30);
        Console.WriteLine("There is {0} name longer than 30 characters.", string.IsNullOrEmpty(firstVeryLongName) ? "not a" : "a");
        string first = names.First(name => name.Length > 10);
        Console.WriteLine(first);



        // any method
        List<string> numbers = new List<string> { "1", "2" };
        bool hasElements = numbers.Any();
        Console.WriteLine("The list {0} empty", hasElements ? "is not" : "is");




        string[] fruits = { "apples", "banana", "mango", "orange", "passionfruit", "grape" };
        var query = fruits.Select((fruit, index) => new { index, str = fruit.Substring(0, index) });
        foreach (var obj in query)
        {
            Console.WriteLine("{0}", obj);
        }



        string[] fruits2 = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };
        string fruit1 = fruits2.Single(fruit => fruit.Length > 10);
        Console.WriteLine(fruit1);




        string[] fruits3 = { };
        string fruit2 = fruits3.SingleOrDefault();
        Console.WriteLine(String.IsNullOrEmpty(fruit2) ? "no such string" : fruit2);



        List<string> fruits4 =
        new List<string> {"apple", "passionfruit", "banana", "mango",
 "orange", "blueberry", "grape", "strawberry"};
        IEnumerable<string> query2 = fruits4.Where(fruit => fruit.Length < 6);
        foreach (string fruit in query2)
        {
            Console.WriteLine(fruit);
        }

        Program[] pets = { new Program { Name= "Barley", Age = "8"},
        new Program { Name = "Boots", Age = "4"},
        new Program { Name = "Whiskers", Age = "1"} };
        IEnumerable<Program> query3 = pets.OrderBy(pet => pet.Age);
        foreach (Program pet in query3)
        {
            Console.WriteLine("{0}  - {1}", pet.Name, pet.Age);
             
        }
    
    

        List<decimal> decimals = new List<decimal> { 6.2m, 8.3m, 0.5m , 1.3m, 6.3m, 0.7m};
        IEnumerable<decimal> query4 = decimals.OrderByDescending(num => num, new Program());
        foreach (decimal num in query4)
        {
            Console.WriteLine(num);
        }
    
    
    
    
    
    }

}