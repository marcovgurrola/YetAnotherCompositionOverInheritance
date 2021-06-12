using System;

namespace ComposedBasketballPositions
{
  public class NotEnoughAbilityException : NotSupportedException
  {
    public NotEnoughAbilityException(AbilityType abilityType)
      : base($"This position has not enough ability to { nameof(abilityType) }")
    {
    }
  }
}