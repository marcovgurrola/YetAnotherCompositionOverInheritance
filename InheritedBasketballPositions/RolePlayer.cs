namespace InheritedBasketballPositions
{
    public class RolePlayer : Position
    {
        public int AboveAverageOverall { get; set; }

        public RolePlayer(int incomeRange, int aboveAverageOverall)
            : base(incomeRange)
        {
            AboveAverageOverall = aboveAverageOverall;
        }
    }
}