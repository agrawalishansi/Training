//we are telling the compiler that this class cannot be instantiated as an object; it can only be derived //
//or inherited by child classes that represent concrete examples of animals.//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public abstract class Animal
    {
        public abstract void Talk();
        public abstract void Move();
    }

    public class Human : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("This blog post is awesome! :)");
        }

        public override void Move()
        {
            Console.WriteLine("I'm walking on 2 feet.");
        }
    }

    public class Dog : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("Woof! WOOF!");
        }

        public override void Move()
        {
            Console.WriteLine("I'm walking on 4 feet.");
        }

    }
}
