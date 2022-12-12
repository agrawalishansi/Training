using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class BusStop
    {
        private Queue<Passenger> _peopleWaiting = new Queue<Passenger>();
        public void PersonArrive(Passenger passenger)
        {
            _peopleWaiting.Enqueue(passenger); ;
            Console.WriteLine($"{passenger} queuing at the bus stop);
        } 
        public void BusArrive(Bus bus)
        {
            Console.WriteLine("\r\nBus arriving");
            while(bus.Space>0 && _peopleWaiting.Count>0)
            {
                Passenger passenger = _peopleWaiting.Dequeue();
                bus.Load(passenger);
            }
        }
    }
}
