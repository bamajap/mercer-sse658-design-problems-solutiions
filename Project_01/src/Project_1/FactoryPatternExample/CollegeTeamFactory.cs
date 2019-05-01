using System;

namespace FactoryPatternExample
{
   public class CollegeTeamFactory : FootballTeamFactory
   {
      private const int COLLEGE_SIZE = 85;

      protected override int RosterSize
      {
         get { return COLLEGE_SIZE; }
      }

      protected override FootballTeam Create(string name, int rosterSize,
                                             OffensiveStyle offense,
                                             DefensiveStyle defense)
      {
         FootballTeam result;
         switch (offense)
         {
            case OffensiveStyle.Balanced:
               result = new BalancedFootballTeam(name, "Balanced Coach", rosterSize);
               break;
            case OffensiveStyle.Aggressive:
               result = new PassHappyFootballTeam(name, "Aggressive Coach", rosterSize);
               break;
            case OffensiveStyle.Conservative:
               result = new BallControlFootballTeam(name, "Conservative Coach", rosterSize);
               break;
            default:
               throw new ArgumentOutOfRangeException("offense");
         }
         return result;
      }
   }
}