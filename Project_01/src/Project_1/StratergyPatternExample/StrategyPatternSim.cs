using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StratergyPatternExample.Original;

namespace StratergyPatternExample
{
   public static class StrategyPatternSim
   {
      public static void Run()
      {
         //RunOriginal();
         RunNew();
      }

      #region New

private static void RunNew()
{
   // The constructor now accepts a new parameter that specifies the offensive behavior.
   var offense = new FootballTeam("Offense", new BalancedOffense(), 11);

   Console.WriteLine("Starting the game.  The score is tied at zero...");
   RunOffensiveSeries(offense);

   Console.WriteLine(
      "{0} is now behind 7-0!  Time to get aggressive with the playcalling...",
      offense.Name);
   offense.OffensiveBehavior = new PassHappyOffense();
   RunOffensiveSeries(offense);

   Console.WriteLine("{0} is now ahead 14-7!  Time to run some clock...",
                     offense.Name);
   offense.OffensiveBehavior = new BallControlOffense();
   RunOffensiveSeries(offense);
}
// This method takes one less parameter now because the offensive behavior logic is contained
// within the FootballTeam class now.
private static void RunOffensiveSeries(FootballTeam team)
{
   for (int i = 0; i < 4; i++)
   {
      team.RunOffensivePlay();
   }
}

      #endregion // New

      #region Old

      private static void RunOriginal()
      {
         var offense = new Original.FootballTeam("Offense", 11);

         Console.WriteLine("Starting the game.  The score is tied at zero...");
         RunOffensiveSeries(offense, OffensivePlay.Balanced);

         Console.WriteLine(
            "{0} is now behind 7-0!  Time to get aggressive with the playcalling...",
            offense.Name);
         RunOffensiveSeries(offense, OffensivePlay.PassHappy);

         Console.WriteLine("{0} is now ahead 14-7!  Time to run some clock...",
                           offense.Name);
         RunOffensiveSeries(offense, OffensivePlay.BallControl);
      }

      private static void RunOffensiveSeries(Original.FootballTeam team, OffensivePlay play)
      {
         for (int i = 0; i < 4; i++)
         {
            team.RunOffensivePlay(play);
         }
      }

      #endregion // Old
   }
}