using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternExample
{
   public abstract class FootballTeamFactory
   {
      #region Attempt #1

      /*
      public static FootballTeam CreateCollegeTeam(string name,
                                                   OffensiveStyle offense =
                                                      OffensiveStyle.Balanced,
                                                   DefensiveStyle defense =
                                                      DefensiveStyle.Balanced)
      {
         return Create(name, COLLEGE_SIZE, offense, defense);
      }

      public static FootballTeam CreateNFLTeam(string name,
                                               OffensiveStyle offense = OffensiveStyle.Balanced,
                                               DefensiveStyle defense = DefensiveStyle.Balanced)
      {
         return Create(name, NFL_SIZE, offense, defense);
      }

      private static FootballTeam Create(string name,
                                         int rosterSize,
                                         OffensiveStyle offense = OffensiveStyle.Balanced,
                                         DefensiveStyle defense = DefensiveStyle.Balanced)
      {
         FootballTeam result;

         switch (offense)
         {
            case OffensiveStyle.Balanced:
               result = new BalancedFootballTeam(name, "Balanced Coach", rosterSize);
               break;
            case OffensiveStyle.Aggressive:
               result = new PassHappyFootballTeam(name, "Pass Happy Coach", rosterSize);
               break;
            case OffensiveStyle.Conservative:
               result = new BallControlFootballTeam(name, "Conservative Coach", rosterSize);
               break;
            default:
               throw new ArgumentOutOfRangeException("offense");
         }

         result.OffensiveStyle = offense;
         result.DefensiveStyle = defense;

         return result;
      }
*/

      #endregion

      protected abstract int RosterSize { get; }

      public FootballTeam Create(string name,
                                 OffensiveStyle offense = OffensiveStyle.Balanced,
                                 DefensiveStyle defense = DefensiveStyle.Balanced)
      {
         var team = Create(name, RosterSize, offense, defense);
         Console.WriteLine("{0} has been created with {1} players.",
                           team.Name,
                           team.Size);
         return team;
      }

      protected abstract FootballTeam Create(string name, int rosterSize,
                                             OffensiveStyle offense,
                                             DefensiveStyle defense);

      // other methods here
   }
}