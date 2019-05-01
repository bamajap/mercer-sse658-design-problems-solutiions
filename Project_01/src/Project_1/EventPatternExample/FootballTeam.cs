using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EventPatternExample
{
   public class FootballTeam  : ITeamObserver, ITeamObservable
   {
      private delegate void FootballTeamChangedEventHandler(
         FootballTeam footballTeam, TeamStateChange changeType);

      private event FootballTeamChangedEventHandler FootballTeamChanged;

      //public event PropertyChangedEventHandler FootballTeamPropertyChanged;

      public string Name { get; private set; }

      private IOffensiveBehavior _offensiveBehavior;

      public IOffensiveBehavior OffensiveBehavior
      {
         get { return _offensiveBehavior; }
         set
         {
            if (_offensiveBehavior != null)
            {
               Console.WriteLine("Changing offensive behavior...");
            }
            _offensiveBehavior = value;
            NotifyListeners(TeamStateChange.Offense);
            //FireEvent(FootballTeamPropertyChanged, new PropertyChangedEventArgs("OffensiveBehavior"));
            //FootballTeamChanged(this,TeamStateChange.Offense);
         }
      }

      public IDefensiveBehavior DefensiveBehavior { get; set; }

      private FootballTeam()
      {
         //subscribers = new List<ITeamObserver>();
      }

      public FootballTeam(string name, IOffensiveBehavior offense, IDefensiveBehavior defense)
         : this()
      {
         Name = name;
         OffensiveBehavior = offense;
         DefensiveBehavior = defense;
      }

      public void RunOffensivePlay()
      {
         OffensiveBehavior.RunPlay();
      }

      public void RunDefensivePlay()
      {
         DefensiveBehavior.DefendPlay();
      }

      #region ITeamObserver Methods

      public void Update(FootballTeam footballTeam, TeamStateChange changeType)
      {
         Console.WriteLine("The opponent's offense has changed to {0}.",
                           footballTeam.OffensiveBehavior.GetType());
      }

      #endregion

      #region ITeamObservable Methods

      //private List<ITeamObserver> subscribers;

      public void Register(ITeamObserver observer)
      {
         //if (!subscribers.Contains(observer))
         //   subscribers.Add(observer);
         FootballTeamChanged += observer.Update;
      }

      public void Unregister(ITeamObserver observer)
      {
         //if (subscribers.Contains(observer))
         //   subscribers.Remove(observer);
         FootballTeamChanged -= observer.Update;
      }

      public void NotifyListeners(TeamStateChange changeType)
      {
         //foreach (var subscriber in subscribers)
         //{
         //   subscriber.Update(this, changeType);
         //}
         if (FootballTeamChanged != null) FootballTeamChanged(this, changeType);
      }

      #endregion

      //private void FireEvent(PropertyChangedEventHandler e, PropertyChangedEventArgs args)
      //{
      //   if (e != null) e(this, args);
      //}

      //public void OpponentTeamPropertyChanged_Handler(object sender,
      //                                                PropertyChangedEventArgs args)
      //{
      //   if (!(sender is FootballTeam)) return;
      //   var opponent = sender as FootballTeam;
      //   if (args.PropertyName.Equals("OffensiveBehavior"))
      //      Console.WriteLine("The opponent's offense has changed to {0}.",
      //                        opponent.OffensiveBehavior.GetType());
      //}
   }
}