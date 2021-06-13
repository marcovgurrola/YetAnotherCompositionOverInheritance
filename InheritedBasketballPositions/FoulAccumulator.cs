namespace InheritedBasketballPositions
{
    public interface IFoulAccumulator
    {
        int FoulAccumulationImpact { get; }
    }

    public class FoulAccumulator : Position, IFoulAccumulator
    {
        public int FoulAccumulationImpact { get; }

        public FoulAccumulator(int incomeRange, int foulAccumulationImpact)
            : base(incomeRange)
        {
            FoulAccumulationImpact = foulAccumulationImpact;
        }
    }
}