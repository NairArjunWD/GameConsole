
namespace GameConsole
{
    public abstract class ISpecialDefense
    {
        public abstract int CalculateDamageReduction(int totalDamage);

        public static ISpecialDefense Null {get; } = new NullDefence();

        private class NullDefence : ISpecialDefense
        {
            public override int CalculateDamageReduction(int totalDamage)
            {
                return 0;
            }
        }
    }
}