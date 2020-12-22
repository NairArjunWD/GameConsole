using System;
using System.Text;
using System.Linq;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            PlayerCharacter sarah = new PlayerCharacter (new DiamondSkinDefense())
            {
                Name = "Sarah",
                Health = 100
            };

            PlayerCharacter amrit = new PlayerCharacter(new IronBoneDefense())
            {
                Name = "Amrit",
                Health = 100
            };

            PlayerCharacter gentry = new PlayerCharacter(new DiamondSkinDefense())
            {
                Name = "Gentry",
                Health = 100
            };
            
            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);

            Console.ReadLine();
        }
    }
}
