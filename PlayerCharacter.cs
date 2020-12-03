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