using System;

namespace AbstractFactoryPatternExample
{
public class BalancedFootballTeam : FootballTeam
{
   private ITeamCreationCriteriaAbstractFactory _teamCreationCriteria;

   public BalancedFootballTeam(
      ITeamCreationCriteriaAbstractFactory teamCreationCriteriaAbstractFactory)
      : base(
         teamCreationCriteriaAbstractFactory.Name,
         teamCreationCriteriaAbstractFactory.HeadCoach,
         teamCreationCriteriaAbstractFactory.RosterSize)
   {
      _teamCreationCriteria = teamCreationCriteriaAbstractFactory;
   }

   protected override void BuildRoster()
   {
      // Build team specific roster here...

      // AddQuarterbacks();
      // AddRunningBacks();
      // etc.
   }
}
}