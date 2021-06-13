namespace InheritedBasketballPositions
{
    public class ScoringPaintProtector : Position,
        IAttacker,
        IDefender,
        IScorer,
        IRebounder,
        IBlocker
    {
        public int AttackImpact { get; set; }
        public int DefenseImpact { get; set; }
        public int ScoreImpact { get; set; }
        public int ReboundImpact { get; set; }
        public int BlockImpact { get; set; }

        public ScoringPaintProtector
        (
            int incomeRange,
            int attackImpact,
            int defenseImpact,
            int scoreImpact,
            int reboundImpact,
            int blockImpact
        )
            : base(incomeRange)
        {
            AttackImpact = attackImpact;
            DefenseImpact = defenseImpact;
            ScoreImpact = scoreImpact;
            ReboundImpact = reboundImpact;
            BlockImpact = blockImpact;
        }
    }
}