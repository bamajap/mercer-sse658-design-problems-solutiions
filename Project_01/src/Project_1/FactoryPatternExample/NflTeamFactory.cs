using System;

namespace FactoryPatternExample
{
   internal class NflTeamFactory : FootballTeamFactory
   {
      private const int NFL_SIZE = 53;

      protected override int RosterSize
      {
         get { return NFL_SIZE; }
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