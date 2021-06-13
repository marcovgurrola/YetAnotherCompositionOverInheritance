using System;

namespace ComposedBasketballPositions
{
    public class PositionFactory
    {      
        public static Position CreatePosition(PositionType positionType)
        {
            Position position;

            switch (positionType)
            {
                case PositionType.OffensiveBallHandler:
                    position = new Position(4);
                    position.AddAbilityType(AbilityType.Attack, 5);
                    position.AddAbilityType(AbilityType.BallHandle, 4);
                    position.AddAbilityType(AbilityType.Score, 3);
                    position.AddAbilityType(AbilityType.FreeThrow, 3);
                    position.AddAbilityType(AbilityType.Shot, 3);
                    break;
                case PositionType.DefensiveBallHandler:
                    position = new Position(5);
                    position.AddAbilityType(AbilityType.Defense, 5);
                    position.AddAbilityType(AbilityType.BallHandle, 4);
                    position.AddAbilityType(AbilityType.Assit, 3);
                    position.AddAbilityType(AbilityType.Steal, 3);
                    break;
                case PositionType.ComboBallHandler:
                    position = new Position(6);
                    position.AddAbilityType(AbilityType.Attack, 3);
                    position.AddAbilityType(AbilityType.Defense, 3);
                    position.AddAbilityType(AbilityType.BallHandle, 3);
                    break;
                case PositionType.ShootingBallHandler:
                    position = new Position(4);
                    position.AddAbilityType(AbilityType.Attack, 4);
                    position.AddAbilityType(AbilityType.BallHandle, 4);
                    position.AddAbilityType(AbilityType.Shot, 4);
                    position.AddAbilityType(AbilityType.Score, 4);
                    break;
                case PositionType.RolePlayingBallHandler:
                    position = new Position(7);
                    position.AddAbilityType(AbilityType.BallHandle, 3);
                    position.AddAbilityType(AbilityType.Minutes, 2);
                    break;
                case PositionType.ThreePointRebounder:
                    position = new Position(5);
                    position.AddAbilityType(AbilityType.Attack, 2);
                    position.AddAbilityType(AbilityType.BallHandle, 2);
                    position.AddAbilityType(AbilityType.Rebound, 4);
                    position.AddAbilityType(AbilityType.ThreePoint, 4);
                    break;
                case PositionType.ScoringRebounder:
                    position = new Position(5);
                    position.AddAbilityType(AbilityType.Attack, 3);
                    position.AddAbilityType(AbilityType.Score, 4);
                    position.AddAbilityType(AbilityType.Rebound, 4);
                    break;
                case PositionType.PaintProtector:
                    position = new Position(6);
                    position.AddAbilityType(AbilityType.Defense, 4);
                    position.AddAbilityType(AbilityType.Block, 4);
                    position.AddAbilityType(AbilityType.Rebound, 4);
                    position.AddAbilityType(AbilityType.FoulAccumulation, 4);
                    break;
                case PositionType.ScoringPaintProtector:
                    position = new Position(5);
                    position.AddAbilityType(AbilityType.Attack, 3);
                    position.AddAbilityType(AbilityType.Defense, 3);
                    position.AddAbilityType(AbilityType.Score, 4);
                    position.AddAbilityType(AbilityType.Rebound, 4);
                    position.AddAbilityType(AbilityType.Block, 4);
                    break;
                case PositionType.NBAFirstTeam:
                    position = new Position(2);
                    position.AddAbilityType(AbilityType.AboveAverageOverall, 4);
                    break;
                case PositionType.NBASecondTeam:
                    position = new Position(3);
                    position.AddAbilityType(AbilityType.AboveAverageOverall, 3);
                    break;
                case PositionType.RolePlayer:
                    position = new Position(8);
                    position.AddAbilityType(AbilityType.AboveAverageOverall, 2);
                    break;
                case PositionType.OneOfAKind:
                    position = new Position(1);
                    position.AddAbilityType(AbilityType.AboveAverageOverall, 5);
                    break;
                default:
                    throw new ArgumentException($"Uncategorized position type: { positionType }");
            }

            return position;
        }
    }
}