using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // var player = new PlayerCharacter();
            // player.Name = "";

            PlayerCharacter player = null;
            // player.DaysSinceLastLogin = 42;

            int days = player?.DaysSinceLastLogin ?? -1;

            // PlayerDisplayer.Write(player);
            Console.WriteLine(days);

            Console.ReadLine();
        }
    }
}
