using System;

namespace InheritedBasketballPositions
{
    public class PositionFactory
    {
        public static Position CreatePosition(PositionType positionType)
        {
            Position position;

            switch (positionType)
            {
                // Just using some positions for demostration
                //case PositionType.OffensiveBallHandler:
                //    break;
                //case PositionType.ShootingBallHandler:
                //    break;
                //case PositionType.DefensiveBallHandler:
                //    break;
                //case PositionType.ThreePointRebounder:
                //    break;
                //case PositionType.ScoringRebounder:
                //    break;
                //case PositionType.ComboBallHandler:
                //    break;
                //case PositionType.RolePlayingBallHandler:
                //    break;
                case PositionType.PaintProtector:
                    position = new PaintProtector(6, 4, 4, 4, 4);
                    break;
                case PositionType.ScoringPaintProtector:
                    position = new ScoringPaintProtector(5, 3, 3, 4, 4, 4);
                    break;
                case PositionType.NBAFirstTeam:
                    position = new NBAFirstTeam(2, 4);
                    break;
                case PositionType.NBASecondTeam:
                    position = new NBASecondTeam(3, 3);
                    break;
                case PositionType.RolePlayer:
                    position = new RolePlayer(8, 2);
                    break;
                case PositionType.OneOfAKind:
                    position = new OneOfAKind(1, 5);
                    break;
                default:
                    throw new ArgumentException($"Uncategorized position type: { nameof(positionType) }");
            }

            return position;
        }
    }
}