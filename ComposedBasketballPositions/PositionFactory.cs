using System;

namespace ComposedBasketballPositions
{
  public class PositionFactory
  {
    public enum PositionType
    {
      OffensiveBallHandler,
      DefensiveBallHandler,
      ComboBallHandler,
      ShootingBallHandler,
      RolePlayingBallHandler,
      ThreePointRebounder,
      ScoringRebounder,
      PaintProtector,
      ScoringPaintProtector,
      NBAFirstTeam,
      NBASecondTeam,
      RolePlayer,
      OneOfAKind
    }

    public static Position CreatePosition(PositionType positionType)
    {
      Position position;

      switch(positionType)
      {
        case PositionType.OffensiveBallHandler:
          position = new Position(1);
          position.AddAbilityType(AbilityType.Attack, 5);
          position.AddAbilityType(AbilityType.BallHandle, 2);
          position.AddAbilityType(AbilityType.Score, 2);
          position.AddAbilityType(AbilityType.FreeThrow, 2);
          position.AddAbilityType(AbilityType.Shot, 2);
          break;
        case PositionType.DefensiveBallHandler:
          position = new Position(2);
          position.AddAbilityType(AbilityType.Defense, 5);
          position.AddAbilityType(AbilityType.BallHandle, 2);
          position.AddAbilityType(AbilityType.Assit, 1);
          position.AddAbilityType(AbilityType.Steal, 2);
          break;
        case PositionType.ComboBallHandler:
          position = new Position(3);
          position.AddAbilityType(AbilityType.Attack, 3);
          position.AddAbilityType(AbilityType.Defense, 3);
          position.AddAbilityType(AbilityType.BallHandle, 2);
          break;
        case PositionType.ShootingBallHandler:
          position = new Position(4);
          position.AddAbilityType(AbilityType.Attack, 4);
          position.AddAbilityType(AbilityType.BallHandle, 2);
          position.AddAbilityType(AbilityType.Shot, 5);
          break;
        case PositionType.RolePlayingBallHandler:
          position = new Position(5);
          break;
        case PositionType.ThreePointRebounder:
          position = new Position(6);
          break;
        case PositionType.ScoringRebounder:
          position = new Position(7);
          break;
        case PositionType.PaintProtector:
          position = new Position(8);
          break;
        case PositionType.ScoringPaintProtector:
          position = new Position(9);
          break;
        case PositionType.NBAFirstTeam:
          position = new Position(10);
          break;
        case PositionType.NBASecondTeam:
          position = new Position(11);
          break;
        case PositionType.RolePlayer:
          position = new Position(12);
          break;
        case PositionType.OneOfAKind:
          position = new Position(13);
          break;
        default:
          throw new ArgumentException($"Uncategorized position type: { nameof(positionType) }");
      }

      return position;
    }
  }
}