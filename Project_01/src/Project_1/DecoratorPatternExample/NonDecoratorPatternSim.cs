using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPatternExample
{
   public static class NonDecoratorPatternSim
   {
      public static void Run()
      {
         Console.WriteLine("***Non-Decorator Applied***");

         var offensiveBehavior = new CollegePistol3Wr1Rb1TeOffense();
         var omniTeam = new FootballTeam("Omni Team", offensiveBehavior, 11);

         Console.WriteLine("Starting the game.  The score is tied at zero...");
         RunOffensiveSeries(omniTeam);

         Console.WriteLine(
            "{0} is now behind 7-0!  Time to get aggressive with the playcalling...",
            omniTeam.Name);
         omniTeam.OffensiveBehavior = new NflShotgun4Wr1RbOffense();
         RunOffensiveSeries(omniTeam);

         Console.WriteLine("{0} is now ahead 14-7!  Time to run some clock...",
                           omniTeam.Name);
         omniTeam.OffensiveBehavior = new HighSchoolWishbone3Rb2TeOffense();
         RunOffensiveSeries(omniTeam);
      }

      private static void RunOffensiveSeries(FootballTeam team)
      {
         for (int i = 0; i < 2; i++)
         {
            team.RunOffensivePlay();
         }
      }
   }
}