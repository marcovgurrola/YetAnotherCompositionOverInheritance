namespace ComposedBasketballPositions
{
  public partial class Position
  {
    public bool IsBallHandler => AbilityTypes.ContainsKey(AbilityType.BallHandle);
    public bool IsScorer => AbilityTypes.ContainsKey(AbilityType.Score);
    public bool IsShooter => AbilityTypes.ContainsKey(AbilityType.Shot);
    public bool IsStealer => AbilityTypes.ContainsKey(AbilityType.Steal);
    public bool IsBlocker => AbilityTypes.ContainsKey(AbilityType.Block);
    public bool IsAssistant => AbilityTypes.ContainsKey(AbilityType.Assit);
    public bool IsFreeThrower => AbilityTypes.ContainsKey(AbilityType.FreeThrow);
    public bool IsThreePointer => AbilityTypes.ContainsKey(AbilityType.ThreePoint);
    public bool IsRebounder => AbilityTypes.ContainsKey(AbilityType.Rebound);
    public bool IsAttacker => AbilityTypes.ContainsKey(AbilityType.Attack);
    public bool IsDefender => AbilityTypes.ContainsKey(AbilityType.Defense);
    public bool IsFoulAccumulator => AbilityTypes.ContainsKey(AbilityType.FoulAccumulation);
    public bool IsAlmostAboveAverageOverall => AbilityTypes.ContainsKey(AbilityType.AlmostAboveAverageOverall);
    public bool IsAboveAverageOverall => AbilityTypes.ContainsKey(AbilityType.AboveAverageOverall);
    public bool IsHighAboveAverageOverall => AbilityTypes.ContainsKey(AbilityType.HighAboveAverageOverall);
    public bool IsGoodOnAllCategories => AbilityTypes.ContainsKey(AbilityType.GoodOnAllCategories);
    public bool IsMinuter => AbilityTypes.ContainsKey(AbilityType.Minutes);
  }
}