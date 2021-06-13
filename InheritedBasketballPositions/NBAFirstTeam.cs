namespace InheritedBasketballPositions
{
    public class NBAFirstTeam : Position
    {
        public int AboveAverageOverall { get; set; }

        public NBAFirstTeam(int incomeRange, int aboveAverageOverall)
            : base(incomeRange)
        {
            AboveAverageOverall = aboveAverageOverall;
        }
    }
}