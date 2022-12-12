using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class PassengerGenerator
    {
        public static int _count = 0;

        public static Passenger CreatePassenger()
        {
             
            string destination = "Lancaster";
           Console.WriteLine( new Passenger($"Person {++_count}", destination));


        }
    }
}
