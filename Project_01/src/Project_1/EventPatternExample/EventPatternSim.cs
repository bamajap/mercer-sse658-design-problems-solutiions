using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventPatternExample
{
   public static class EventPatternSim
   {
      public static void Run()
      {
         Console.WriteLine();
         Console.WriteLine("***Event-Based Observer Pattern***");

         var offense = new FootballTeam("Offense", new BalancedOffense(),
                                          new BalancedDefense());
         var defense = new FootballTeam("Defense", new BalancedOffense(),
                                          new BalancedDefense());
         var officiatingCrew = new OfficiatingCrew();

         offense.Register(officiatingCrew);
         //defense.Register(officiatingCrew);
         //offense.FootballTeamPropertyChanged += officiatingCrew.FootballTeamPropertyChangedHandler;

         offense.Register(defense);
         //defense.Register(offense);
         //offense.FootballTeamPropertyChanged += defense.OpponentTeamPropertyChanged_Handler;

         Console.WriteLine("Starting the game.  The score is tied at zero...");

         RunPlay(offense, defense);

         offense.OffensiveBehavior = new BallControlOffense();
         RunPlay(offense, defense);

         offense.OffensiveBehavior = new IllegalOffense();
         RunPlay(offense, defense);

         offense.OffensiveBehavior = new PassHappyOffense();
         RunPlay(offense, defense);
      }


      private static void RunPlay(FootballTeam offense, FootballTeam defense)
      {
         offense.RunOffensivePlay();
         defense.RunDefensivePlay();
         Console.WriteLine("---This play is over---");
      }
   }
}