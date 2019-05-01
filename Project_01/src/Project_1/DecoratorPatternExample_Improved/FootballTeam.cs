using System;

namespace DecoratorPatternExample_Improved
{
public class FootballTeam
{
   protected readonly int _rosterSize;

   private string _name;

   public string Name
   {
      get { return string.Format("[{0}]", _name); }
      private set { _name = value; }
   }

   public IOffensiveBehavior OffensiveBehavior { get; set; }

   private FootballTeam()
   {
   }

   public FootballTeam(string name, int size)
   {
      Name = name;
      _rosterSize = size;
   }

   public FootballTeam(string name, IOffensiveBehavior offense, int size)
      : this(name, size)
   {
      OffensiveBehavior = offense;
   }

   public void RunOffensivePlay()
   {
      var msg = OffensiveBehavior.RunPlay();
      Console.WriteLine("The {0} offense ran a play...", msg);
   }
}
}