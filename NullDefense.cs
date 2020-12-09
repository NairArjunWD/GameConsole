
namespace GameConsole
{
    class NullDefense : SpecialDefense
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 0;
        }
    }
}