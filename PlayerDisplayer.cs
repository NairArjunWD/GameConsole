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
        }
    }
}
