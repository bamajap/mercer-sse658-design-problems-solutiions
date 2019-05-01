using System;

namespace FactoryPatternExample
{
   public static class FactoryPatternSim
   {
public static void Run()
{
   Console.WriteLine("***Factory Method Pattern***");

   var collegeTeamFactory = new CollegeFootballTeamFactory();
   var collegeSim = new FootballGameSim(collegeTeamFactory);

   var nflTeamFactory = new NflFootballTeamFactory();
   var nflSim = new FootballGameSim(nflTeamFactory);

   for (int i = 0; i < 3; i++)
   {
      collegeSim.Run((OffensiveType) i);
      nflSim.Run((OffensiveType) i);
   }
}
   }
}