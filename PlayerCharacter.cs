using System;

namespace GameConsole
{
    class PlayerCharacter
    {
        public string Name {get; set;}

        public int Health {get; set;} = 100;

        public void Hit(int damage)
        {
            int damageReduction = 0;

            int totalDamageTaken = damage - damageReduction;

            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
        }

        

        public int? DaysSinceLastLogin {get; set;}
        public DateTime? DateOfBirth {get; set;}

        public PlayerCharacter()
        {
            DateOfBirth = null;
            DaysSinceLastLogin = null;
        }
    }
}