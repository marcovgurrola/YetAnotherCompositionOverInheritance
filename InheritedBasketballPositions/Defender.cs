namespace InheritedBasketballPositions
{
    public interface IDefender
    {
        int DefenseImpact { get; }
    }

    public class Defender : Position, IDefender
    {
        public int DefenseImpact { get; }

        public Defender(int incomeRange, int defenseImpact)
            : base(incomeRange)
        {
            DefenseImpact = defenseImpact;
        }
    }
}