using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "";

            PlayerDisplayer.Write(player);

            Console.ReadLine();
        }
    }
}
