namespace InheritedBasketballPositions
{
    public interface IBlocker
    {
        int BlockImpact { get; }
    }

    public class Blocker : Position, IBlocker
    {
        public int BlockImpact { get; }

        public Blocker(int incomeRange, int blockImpact)
            : base(incomeRange)
        {
            BlockImpact = blockImpact;
        }
    }
}