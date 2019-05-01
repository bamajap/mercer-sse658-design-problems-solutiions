using System;

namespace AbstractFactoryPatternExample
{
public class BallControlFootballTeam : FootballTeam
{
   private ITeamCreationCriteriaAbstractFactory _teamCreationCriteria;

   public BallControlFootballTeam(
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