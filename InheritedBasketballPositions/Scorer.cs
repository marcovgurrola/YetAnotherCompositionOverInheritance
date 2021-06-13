namespace InheritedBasketballPositions
{
    public interface IScorer
    {
        int ScoreImpact { get; }
    }

    public class Scorer : Position
    {
        public int ScoreImpact { get; }

        public Scorer(int incomeRange, int scoreImpact)
            : base(incomeRange)
        {
            ScoreImpact = scoreImpact;
        }
    }
}