using InheritedBasketballPositions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritedBasketballPositionsTests
{
    [TestClass]
    public class PositionTests
    {
        [TestMethod]
        public void PaintProtector_Test()
        {
            Position paintProtector = PositionFactory.CreatePosition(PositionType.PaintProtector);

            // Tests will because cannot inherit from multiple base classes.
            Assert.IsTrue(paintProtector is Defender);
            Assert.IsTrue(paintProtector is Blocker);
            Assert.IsTrue(paintProtector is Rebounder);
            Assert.IsTrue(paintProtector is FoulAccumulator);
        }

        [TestMethod]
        public void ScoringPaintProtector_Test()
        {
            Position scoringPaintProtector = PositionFactory.CreatePosition(PositionType.ScoringPaintProtector);

            // Tests will because cannot inherit from multiple base classes.
            Assert.IsTrue(scoringPaintProtector is Attacker);
            Assert.IsTrue(scoringPaintProtector is Defender);
            Assert.IsTrue(scoringPaintProtector is Scorer);
            Assert.IsTrue(scoringPaintProtector is Rebounder);
            Assert.IsTrue(scoringPaintProtector is Blocker);
        }

        [TestMethod]
        public void NBAFirstTeam_Test()
        {
            NBAFirstTeam nbaFirstTeam = PositionFactory.CreatePosition(PositionType.NBAFirstTeam) as NBAFirstTeam;

            Assert.IsTrue(nbaFirstTeam.AboveAverageOverall == 4);
        }

        [TestMethod]
        public void NBASecondTeam_Test()
        {
            NBASecondTeam nbaSecondTeam = PositionFactory.CreatePosition(PositionType.NBASecondTeam) as NBASecondTeam;

            Assert.IsTrue(nbaSecondTeam.AboveAverageOverall == 3);
        }

        [TestMethod]
        public void RolePlayer_Test()
        {
            RolePlayer rolePlayer = PositionFactory.CreatePosition(PositionType.RolePlayer) as RolePlayer;

            Assert.IsTrue(rolePlayer.AboveAverageOverall == 2);
        }

        [TestMethod]
        public void OneOfAKind_Test()
        {
            OneOfAKind oneOfAKind = PositionFactory.CreatePosition(PositionType.OneOfAKind) as OneOfAKind;

            Assert.IsTrue(oneOfAKind.AboveAverageOverall == 5);
        }
    }
}
