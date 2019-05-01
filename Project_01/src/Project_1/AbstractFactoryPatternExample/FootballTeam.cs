using System;

namespace AbstractFactoryPatternExample
{
public abstract class FootballTeam
{
   public int RosterSize { get; private set; }
   public string Name { get; private set; }
   public string HeadCoach { get; private set; }
   public IOffensiveBehavior OffensiveBehavior { get; set; }

   protected FootballTeam(string name, string coach, int rosterSize)
   {
      Name = name;
      HeadCoach = coach;
      RosterSize = rosterSize;
      BuildRoster();
   }

   public void RunOffensivePlay()
   {
      OffensiveBehavior.RunPlay();
   }

   protected abstract void BuildRoster();
}
}