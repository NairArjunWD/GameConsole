
namespace GameConsole
{
    class NullDefence : ISpecialDefense
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 0;
        }
    }
}