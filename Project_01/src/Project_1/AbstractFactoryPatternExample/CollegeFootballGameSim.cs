using System;

namespace AbstractFactoryPatternExample
{
public class CollegeFootballGameSim : FootballGameSim
{
   protected override FootballTeam CreateTeam(OffensiveType type)
   {
      FootballTeam result;

      var collegeCriteriaAbstractFactory =
         new CollegeTeamCreationCriteriaAbstractFactory(type);

      switch (type)
      {
         case OffensiveType.Balanced:
            result = new BalancedFootballTeam(collegeCriteriaAbstractFactory);
            break;
         case OffensiveType.PassHappy:
            result = new PassHappyFootballTeam(collegeCriteriaAbstractFactory);
            break;
         case OffensiveType.BallControl:
            result = new BallControlFootballTeam(collegeCriteriaAbstractFactory);
            break;
         default:
            throw new ArgumentOutOfRangeException("type");
      }

      return result;
   }
}
}