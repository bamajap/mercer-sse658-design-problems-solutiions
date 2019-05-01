using System;
using System.Collections.Generic;
using FactoryPatternExample.Interfaces;

namespace FactoryPatternExample
{
   //public abstract class FootballTeam
   //{
   //   public const string RUN_PLAY_MSG = "Ran a running play...";
   //   public const string PASS_PLAY_MSG = "Ran a passing play...";

   //   protected List<IFootballPlayer> _players;
   //   protected readonly int _rosterSize;

   //   public string Name { get; private set; }
   //   public IPerson HeadCoach { get; private set; }
   //   public OffensiveStyle OffensiveStyle { get; set; }
   //   public DefensiveStyle DefensiveStyle { get; set; }

   //   public IList<IFootballPlayer> Roster
   //   {
   //      get { return _players.AsReadOnly(); }
   //   }

   //   public int Size
   //   {
   //      get { return _rosterSize; }
   //   }

   //   protected FootballTeam()
   //   {
   //      _players = new List<IFootballPlayer>();
   //   }

   //   protected FootballTeam(string name, string coach, int rosterSize)
   //      : this()
   //   {
   //      Name = name;
   //      HeadCoach = new HeadCoach(coach);
   //      _rosterSize = rosterSize;
   //   }

   //   public void CallTimeout()
   //   {
   //      Console.WriteLine("{0} has called a timeout.", Name);
   //   }

   //   public abstract void RunOffensivePlay();
   //}

public abstract class FootballTeam
{
   protected readonly int _rosterSize;

   public int RosterSize
   {
      get { return _rosterSize; }
   }

   public string Name { get; protected set; }
   public string HeadCoach { get; protected set; }

   public IOffensiveBehavior OffensiveBehavior { get; set; }

   protected FootballTeam()
   {
      _rosterSize = -1;
   }

   protected FootballTeam(int rosterSize)
   {
      _rosterSize = rosterSize;
   }

   public void RunOffensivePlay()
   {
      OffensiveBehavior.RunPlay();
   }
}

}