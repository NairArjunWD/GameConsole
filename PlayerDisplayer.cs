using System;
using System.Collections.Generic;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write (PlayerCharacter player)
        {
            Console.WriteLine(player.Name);

            if (player.DaysSinceLastLogin.HasValue)
            {
                Console.WriteLine(player.DaysSinceLastLogin.Value);
            }
            else 
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No date of birth specified");
            }
            else  
            {
                Console.WriteLine(player.DateOfBirth);
            }

            int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;

            Console.WriteLine($"{days} days since last login");
        }
    }
}
