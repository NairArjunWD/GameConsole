using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            PlayerCharacter sarah = new PlayerCharacter (new DiamondSkinDefense())
            {
                Name = "Sarah"
            };

            PlayerCharacter amrit = new PlayerCharacter(new IronBoneDefense())
            {
                Name = "Amrit"
            };

            PlayerCharacter gentry = new PlayerCharacter(new DiamondSkinDefense())
            {
                Name = "Gentry"
            };
            
            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);

            Console.ReadLine();
        }
    }
}
