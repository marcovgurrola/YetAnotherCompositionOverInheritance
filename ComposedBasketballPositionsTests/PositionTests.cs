using ComposedBasketballPositions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComposedBasketballPositionsTests
{
    [TestClass]
    public class PositionTests
    {
        [TestMethod]
        public void OffensiveBallHandler_Test()
        {
            Position offensiveBallHandler = PositionFactory.CreatePosition(PositionType.OffensiveBallHandler);

            Assert.IsTrue(offensiveBallHandler.IsAttacker);
            Assert.IsTrue(offensiveBallHandler.IsBallHandler);
            Assert.IsTrue(offensiveBallHandler.IsScorer);
            Assert.IsTrue(offensiveBallHandler.IsFreeThrower);
            Assert.IsTrue(offensiveBallHandler.IsShooter);
        }

        [TestMethod]
        public void DefensiveBallHandler_Test()
        {
            Position defensiveBallHandler = PositionFactory.CreatePosition(PositionType.DefensiveBallHandler);

            Assert.IsTrue(defensiveBallHandler.IsDefender);
            Assert.IsTrue(defensiveBallHandler.IsBallHandler);
            Assert.IsTrue(defensiveBallHandler.IsAssistant);
            Assert.IsTrue(defensiveBallHandler.IsStealer);
        }

        [TestMethod]
        public void ComboBallHandler_Test()
        {
            Position comboBallHandler = PositionFactory.CreatePosition(PositionType.ComboBallHandler);

            Assert.IsTrue(comboBallHandler.IsAttacker);
            Assert.IsTrue(comboBallHandler.IsDefender);
            Assert.IsTrue(comboBallHandler.IsBallHandler);
        }

        [TestMethod]
        public void ShootingBallHandler_Test()
        {
            Position shootingBallHandler = PositionFactory.CreatePosition(PositionType.ShootingBallHandler);

            Assert.IsTrue(shootingBallHandler.IsAttacker);
            Assert.IsTrue(shootingBallHandler.IsBallHandler);
            Assert.IsTrue(shootingBallHandler.IsShooter);
            Assert.IsTrue(shootingBallHandler.IsScorer);
        }

        [TestMethod]
        public void RolePlayingBallHandler_Test()
        {
            Position rolePlayingBallHandler = PositionFactory.CreatePosition(PositionType.RolePlayingBallHandler);

            Assert.IsTrue(rolePlayingBallHandler.IsBallHandler);
            Assert.IsTrue(rolePlayingBallHandler.AbilityTypes[AbilityType.Minutes] == 2);
        }

        [TestMethod]
        public void ThreePointRebounder_Test()
        {
            Position threePointRebounder = PositionFactory.CreatePosition(PositionType.ThreePointRebounder);

            Assert.IsTrue(threePointRebounder.IsAttacker);
            Assert.IsTrue(threePointRebounder.IsBallHandler);
            Assert.IsTrue(threePointRebounder.IsRebounder);
            Assert.IsTrue(threePointRebounder.IsThreePointer);
        }

        [TestMethod]
        public void ScoringRebounder_Test()
        {
            Position scoringRebounder = PositionFactory.CreatePosition(PositionType.ScoringRebounder);

            Assert.IsTrue(scoringRebounder.IsAttacker);
            Assert.IsTrue(scoringRebounder.IsScorer);
            Assert.IsTrue(scoringRebounder.IsRebounder);
        }

        [TestMethod]
        public void PaintProtector_Test()
        {
            Position paintProtector = PositionFactory.CreatePosition(PositionType.PaintProtector);

            Assert.IsTrue(paintProtector.IsDefender);
            Assert.IsTrue(paintProtector.IsBlocker);
            Assert.IsTrue(paintProtector.IsRebounder);
            Assert.IsTrue(paintProtector.IsFoulAccumulator);
        }

        [TestMethod]
        public void ScoringPaintProtector_Test()
        {
            Position scoringPaintProtector = PositionFactory.CreatePosition(PositionType.ScoringPaintProtector);

            Assert.IsTrue(scoringPaintProtector.IsAttacker);
            Assert.IsTrue(scoringPaintProtector.IsDefender);
            Assert.IsTrue(scoringPaintProtector.IsScorer);
            Assert.IsTrue(scoringPaintProtector.IsRebounder);
            Assert.IsTrue(scoringPaintProtector.IsBlocker);
        }

        [TestMethod]
        public void NBAFirstTeam_Test()
        {
            Position nbaFirstTeam = PositionFactory.CreatePosition(PositionType.NBAFirstTeam);

            Assert.IsTrue(nbaFirstTeam.IsAboveAverageOverall);
            Assert.IsTrue(nbaFirstTeam.AbilityTypes[AbilityType.AboveAverageOverall] == 4);
        }

        [TestMethod]
        public void NBASecondTeam_Test()
        {
            Position nbaSecondTeam = PositionFactory.CreatePosition(PositionType.NBASecondTeam);

            Assert.IsTrue(nbaSecondTeam.IsAboveAverageOverall);
            Assert.IsTrue(nbaSecondTeam.AbilityTypes[AbilityType.AboveAverageOverall] == 3);
        }

        [TestMethod]
        public void RolePlayer_Test()
        {
            Position rolePlayer = PositionFactory.CreatePosition(PositionType.RolePlayer);

            Assert.IsTrue(rolePlayer.IsAboveAverageOverall);
            Assert.IsTrue(rolePlayer.AbilityTypes[AbilityType.AboveAverageOverall] == 2);
        }

        [TestMethod]
        public void OneOfAKind_Test()
        {
            Position oneOfAKind = PositionFactory.CreatePosition(PositionType.OneOfAKind);

            Assert.IsTrue(oneOfAKind.IsAboveAverageOverall);
            Assert.IsTrue(oneOfAKind.AbilityTypes[AbilityType.AboveAverageOverall] == 5);
        }
    }
}