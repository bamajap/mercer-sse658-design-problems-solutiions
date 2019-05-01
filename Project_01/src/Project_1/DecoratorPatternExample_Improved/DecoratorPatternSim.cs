using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPatternExample_Improved
{
   public static class DecoratorPatternSim
   {
public static void Run()
{
   Console.WriteLine("***Decorator Pattern***");
   IOffensiveBehavior offensiveBehavior;

   offensiveBehavior = new _1Te(new _1Rb(new _3Wr(new Pistol(new CollegeOffense()))));
   var omniTeam = new FootballTeam("Omni Team", offensiveBehavior, 11);

   Console.WriteLine("Starting the game.  The score is tied at zero...");
   RunOffensiveSeries(omniTeam);

   Console.WriteLine(
      "{0} is now behind 7-0!  Time to get aggressive with the playcalling...",
      omniTeam.Name);
   offensiveBehavior = new _1Rb(new _4Wr(new Shotgun(new NflOffense())));
   omniTeam.OffensiveBehavior = offensiveBehavior;
   RunOffensiveSeries(omniTeam);

   Console.WriteLine("{0} is now ahead 14-7!  Time to run some clock...",
                     omniTeam.Name);
   offensiveBehavior = new _2Te(new _3Rb(new Wishbone(new HighSchoolOffense())));
   omniTeam.OffensiveBehavior = offensiveBehavior;
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