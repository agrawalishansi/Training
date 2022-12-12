
public class BusRouteRepository
{ 



//public static Class1[] InitializeRoutes()
//{

//    return new Class1[]
//    {
//    new Class1(40, "Morecambe","Preston"), 
//        new Class1(42, "Lancaster", "Blackpool"),

//new Class1(100, "University", "Morecambe"),

//new Class1(555, "Lancaster", "Keswick")


//    };
//}
//}



public static Dictionary<int, Class1> InitializeRoutes()
{
    Class1 route42 =new Class1(42,

    new string[]{"Lancaster", "Garstang", "Blackpool"});

Class1 route40= new Class1(40,

new string[]{"Morecambe", "Lancaster", "Garstang", "Preston" });
        
    Class1 route100= new Class1(100,

new string[]{"University", "Lancaster", "Morecambe" });

Class1 route555= new Class1(555, new string[] { "Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick" });

Class1 route5 = new Class1(5, new string[] { "Overton", "Morecambe", "Carnforth" });

var routes =new Dictionary<int, Class1> ();

routes.Add(42, route42); routes.Add(40, route40);

routes.Add(100, route100); routes.Add(555,

route555);
        //string[,] timesRoute5 =
        //{
        //    {"15:40", "16:40","17:40","18:40" },
        //    { "16:08", "17:08","18:08","19:08" },
        //    { "16:35", "17:35","18:35","19:35"}
        //};
        //BusTimesRoute5 = new BusTimes(
        //    Array.Find(_allRoutes, x => x.Number == 5), timesRoute5);
}
}

