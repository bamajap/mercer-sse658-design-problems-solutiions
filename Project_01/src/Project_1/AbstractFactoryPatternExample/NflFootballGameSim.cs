using System;

namespace AbstractFactoryPatternExample
{
public class NflFootballGameSim : FootballGameSim
{
   protected override FootballTeam CreateTeam(OffensiveType type)
   {
      FootballTeam result;

      var nflCriteriaAbstractFactory =
         new NflTeamCreationCriteriaAbstractFactory(type);

      switch (type)
      {
         case OffensiveType.Balanced:
            result = new BalancedFootballTeam(nflCriteriaAbstractFactory);
            break;
         case OffensiveType.PassHappy:
            result = new PassHappyFootballTeam(nflCriteriaAbstractFactory);
            break;
         case OffensiveType.BallControl:
            result = new BallControlFootballTeam(nflCriteriaAbstractFactory);
            break;
         default:
            throw new ArgumentOutOfRangeException("type");
      }

      return result;
   }
}
}