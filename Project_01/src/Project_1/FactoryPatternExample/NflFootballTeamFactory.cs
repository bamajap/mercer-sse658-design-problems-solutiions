using System;
using FactoryPatternExample.Interfaces;

namespace FactoryPatternExample
{
public class NflFootballTeamFactory : IFootballTeamFactory
{
   public FootballTeam Create(OffensiveType type)
   {
      FootballTeam result;

      //var name = string.Format("[{0} NFL Team]", type);
      //var coach = string.Format("{0} {1}", type, "NFL Coach");
      //const int nflRosterSize = 53;

      switch (type)
      {
         case OffensiveType.Balanced:
            result = new NflBalancedFootballTeam(/*name, coach, nflRosterSize*/);
            break;
         case OffensiveType.PassHappy:
            result = new NflPassHappyFootballTeam(/*name, coach, nflRosterSize*/);
            break;
         case OffensiveType.BallControl:
            result = new NflBallControlFootballTeam(/*name, coach, nflRosterSize*/);
            break;
         default:
            throw new ArgumentOutOfRangeException("type");
      }

      return result;
   }
}
}