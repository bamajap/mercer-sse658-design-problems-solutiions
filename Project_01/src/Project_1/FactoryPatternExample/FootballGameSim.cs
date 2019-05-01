using System;
using FactoryPatternExample.Interfaces;

namespace FactoryPatternExample
{
public class FootballGameSim
{
   private readonly IFootballTeamFactory _teamFactory;

   public FootballGameSim(IFootballTeamFactory footballTeamFactory)
   {
      _teamFactory = footballTeamFactory;
   }

   public void Run(OffensiveType type)
   {
      var team = _teamFactory.Create(type);

      RunSim(team);
   }

   private static void RunSim(FootballTeam team)
   {
      Console.WriteLine("{0} is coached by {1} and has {2} players on the roster.",
                        team.Name, team.HeadCoach, team.RosterSize);
      Console.WriteLine("Starting the game.  The score is tied 0-0...");
      team.OffensiveBehavior = new BalancedOffense();
      RunOffensiveSeries(team);

      Console.WriteLine(
         "{0} is now behind 7-0!  Time to get aggressive with the playcalling...",
         team.Name);
      team.OffensiveBehavior = new PassHappyOffense();
      RunOffensiveSeries(team);

      Console.WriteLine("{0} is now ahead 14-7!  Time to run some clock...",
                        team.Name);
      team.OffensiveBehavior = new BallControlOffense();
      RunOffensiveSeries(team);

      Console.WriteLine("The game is over!" + Environment.NewLine);
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