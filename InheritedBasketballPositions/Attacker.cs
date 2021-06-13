namespace InheritedBasketballPositions
{
    public interface IAttacker
    {
        int AttackImpact { get; }
    }

    public class Attacker : Position, IAttacker
    {
        public int AttackImpact { get; set; }

        public Attacker(int incomeRange, int attackImpact)
            : base(incomeRange)
        {
            AttackImpact = attackImpact;
        }
    }
}