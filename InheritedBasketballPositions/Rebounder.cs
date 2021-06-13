namespace InheritedBasketballPositions
{
    public interface IRebounder
    {
        int ReboundImpact { get; }
    }

    public class Rebounder : Position, IRebounder
    {
        public int ReboundImpact { get; }

        public Rebounder(int incomeRange, int reboundImpact)
            : base(incomeRange)
        {
            ReboundImpact = reboundImpact;
        }
    }
}