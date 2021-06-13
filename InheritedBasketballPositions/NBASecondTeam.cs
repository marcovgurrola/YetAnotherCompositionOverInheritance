namespace InheritedBasketballPositions
{
    public class NBASecondTeam : Position
    {
        public int AboveAverageOverall { get; set; }

        public NBASecondTeam(int incomeRange, int aboveAverageOverall)
            : base(incomeRange)
        {
            AboveAverageOverall = aboveAverageOverall;
        }
    }
}