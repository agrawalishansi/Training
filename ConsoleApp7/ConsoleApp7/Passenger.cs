using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Passenger
    {
        public string Name { get; init; }
        public string Destination { get; init; }
        public Passenger(string name, string destination) {
        this.Name = name;
            this.Destination = destination;
        
        
        }
        public override string ToString() => $"{Name} to {Destination}";

    }
}
