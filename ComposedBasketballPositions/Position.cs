using System.Collections.Generic;

namespace ComposedBasketballPositions
{
    public partial class Position
    {
        public int IncomeRange { get; set; }
        public Dictionary<AbilityType, int> AbilityTypes { get; set; }

        public Position(int incomeRange)
        {
            IncomeRange = incomeRange;
            AbilityTypes = new Dictionary<AbilityType, int>();
        }

        public void AddAbilityType(AbilityType abilityType, int impact)
        {
            AbilityTypes[abilityType] = impact;
        }

        public int BallHandlerImpact
        {
            get => IsBallHandler
                    ? AbilityTypes[AbilityType.BallHandle]
                    : throw new NotEnoughAbilityException(AbilityType.BallHandle);
        }

        public int ScorerImpact
        {
            get => IsScorer
                    ? AbilityTypes[AbilityType.Score]
                    : throw new NotEnoughAbilityException(AbilityType.Score);
        }

        public int ShooterImpact
        {
            get => IsScorer
                    ? AbilityTypes[AbilityType.Shot]
                    : throw new NotEnoughAbilityException(AbilityType.Shot);
        }

        public int StealerImpact
        {
            get => IsBallHandler
                    ? AbilityTypes[AbilityType.Steal]
                    : throw new NotEnoughAbilityException(AbilityType.Steal);
        }

        public int BlockerImpact
        {
            get => IsScorer
                    ? AbilityTypes[AbilityType.Block]
                    : throw new NotEnoughAbilityException(AbilityType.Block);
        }

        public int AssistantImpact
        {
            get => IsScorer
                    ? AbilityTypes[AbilityType.Assit]
                    : throw new NotEnoughAbilityException(AbilityType.Assit);
        }

        public int FreeThrowerImpact
        {
            get => IsBallHandler
                    ? AbilityTypes[AbilityType.FreeThrow]
                    : throw new NotEnoughAbilityException(AbilityType.FreeThrow);
        }

        public int ThreePointerImpact
        {
            get => IsScorer
                    ? AbilityTypes[AbilityType.ThreePoint]
                    : throw new NotEnoughAbilityException(AbilityType.ThreePoint);
        }

        public int RebounderImpact
        {
            get => IsScorer
                    ? AbilityTypes[AbilityType.Rebound]
                    : throw new NotEnoughAbilityException(AbilityType.Rebound);
        }

        public int AttackerImpact
        {
            get => IsBallHandler
                    ? AbilityTypes[AbilityType.Attack]
                    : throw new NotEnoughAbilityException(AbilityType.Attack);
        }

        public int DefenderImpact
        {
            get => IsScorer
                    ? AbilityTypes[AbilityType.Defense]
                    : throw new NotEnoughAbilityException(AbilityType.Defense);
        }

        public int FoulAccumulatorImpact
        {
            get => IsScorer
                    ? AbilityTypes[AbilityType.FoulAccumulation]
                    : throw new NotEnoughAbilityException(AbilityType.FoulAccumulation);
        }

        public int AboveAverageOverallImpact
        {
            get => IsBallHandler
                    ? AbilityTypes[AbilityType.AboveAverageOverall]
                    : throw new NotEnoughAbilityException(AbilityType.AboveAverageOverall);
        }

        public int MinutesImpact
        {
            get => IsScorer
                    ? AbilityTypes[AbilityType.Minutes]
                    : throw new NotEnoughAbilityException(AbilityType.Minutes);
        }
    }
}