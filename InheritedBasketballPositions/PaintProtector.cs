namespace InheritedBasketballPositions
{
    public class PaintProtector : Position,
        IDefender,
        IBlocker,
        IRebounder,
        IFoulAccumulator
    {
        public int DefenseImpact { get; }
        public int BlockImpact { get; }
        public int ReboundImpact { get; }
        public int FoulAccumulationImpact { get; }

        public PaintProtector
        (
            int incomeRange,
            int defenseImpact,
            int blockImpact,
            int reboundImpact,
            int foulAccumulationImpact
        )
            : base(incomeRange)
        {
            DefenseImpact = defenseImpact;
            BlockImpact = blockImpact;
            ReboundImpact = reboundImpact;
            FoulAccumulationImpact = foulAccumulationImpact;

        }
    }
}