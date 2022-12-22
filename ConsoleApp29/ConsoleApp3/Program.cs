using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "Sarah";
            //player.DaysSinceLastLogin = 42;

            PlayerDisplayer.Write(player);

            Console.ReadLine();
        }
    }
}
