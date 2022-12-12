class Program
{
    //static void Main(string[] args)
    //{
    //    Class1 route40 = new Class1(40, "Morecambe", "preston");
    //    Class1 route42 =new Class1(42, "Lancaster", "Blackpool");
    //        Class1[] routes =

    //    {

    //route40,

    //route42,

    //new Class1(100, "University", "Morecambe"), new Class1 (555, "Lancaster", "Keswick")

    //};

    //        foreach (Class1 route in routes) { 

    //        Console.WriteLine(route);

    //    }
    //}
    //}

    //namespace ConsoleApp5 { 
    //class Program { 
    //static void Main(string[] args)
    //{

    //            Class1[] allRoutes= BusRouteRepository.InitializeRoutes();

    //    Console.WriteLine("Where do you want to go to?"); string location = Console.ReadLine();

    //    Class1 route = FindBusTo(allRoutes, location); if (route != null)

    //        Console.WriteLine($"You can use route {route}");
    //    else
    //        Console.WriteLine($"No routes go to {location}");
    //}



    //public static Class1 FindBusTo(Class1[] routes, string location)
    //{  foreach (Class1 route in routes)

    //{

    //    if (route.Origin ==location || route.Destination== location) return route;
    //}
    //    return null;
    //}
    //}
    //}


    static void Main(string[] args)



    {

        var allRoutes = BusRouteRepository.InitializeRoutes();

        Console.WriteLine("which route do you want to look up?");

        int number = int.Parse(Console.ReadLine());

        Class1 answer = allRoutes[number];

        if (answer != null)

            Console.WriteLine($"The route you asked for is {answer}");

        else

            Console.WriteLine($"There is no route with number {number}");
    }

}
    // enumerating a 2D array
//    for (int iPlace = 0; iPlace<route5.PlacesServed.Length; iPlace++)
//{
//Console.Write(route5.PlacesServed[iPlace].PadRight(12));

//for (int iJourney=0; iJourney times5.Times.GetLength(1); Journey++) Console.Write(times5.Times[iPlace, iJourney] + " "); Console.WriteLine();
//}
