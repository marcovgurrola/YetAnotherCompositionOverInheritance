namespace InheritedBasketballPositions
{
    public class OneOfAKind : Position
    {
        public int AboveAverageOverall { get; set; }

        public OneOfAKind(int incomeRange, int aboveAverageOverall)
            : base(incomeRange)
        {
            AboveAverageOverall = aboveAverageOverall;
        }
    }
}