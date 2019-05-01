using System;
using FactoryPatternExample.Interfaces;

namespace FactoryPatternExample
{
public class CollegeFootballTeamFactory : IFootballTeamFactory
{
   public FootballTeam Create(OffensiveType type)
   {
      FootballTeam result;

      //var name = string.Format("[{0} College Team]", type);
      //var coach = string.Format("{0} {1}", type, "College Coach");
      //const int collegeRosterSize = 85;

      switch (type)
      {
         case OffensiveType.Balanced:
            result = new CollegeBalancedFootballTeam(/*name, coach, collegeRosterSize*/);
            break;
         case OffensiveType.PassHappy:
            result = new CollegePassHappyFootballTeam(/*name, coach, collegeRosterSize*/);
            break;
         case OffensiveType.BallControl:
            result = new CollegeBallControlFootballTeam(/*name, coach, collegeRosterSize*/);
            break;
         default:
            throw new ArgumentOutOfRangeException("type");
      }

      return result;
   }
}
}