using System;
using System.ComponentModel;

namespace EventPatternExample
{
   internal class OfficiatingCrew : ITeamObserver
   {
      //public void FootballTeamPropertyChangedHandler(object sender, PropertyChangedEventArgs e)
      //{
      //   if (!(sender is FootballTeam)) return;

      //   var team = sender as FootballTeam;
      //   var property = e.PropertyName;
      //   switch (property)
      //   {
      //      case "OffensiveBehavior":
      //         if (team.OffensiveBehavior is IllegalOffense)
      //            Console.WriteLine("\tPENALTY!! --> The offense is illegal!");
      //         else
      //            Console.WriteLine("The officiating crew has OK'd this offense.");
      //         break;
      //   }
      //}

      public void Update(FootballTeam footballTeam, TeamStateChange changeType)
      {
         switch (changeType)
         {
            case TeamStateChange.Offense:
               if (footballTeam.OffensiveBehavior is IllegalOffense)
                  Console.WriteLine("\tPENALTY!! --> The offense is illegal!");
               else
                  Console.WriteLine("The officiating crew has OK'd this offense.");
               break;
            case TeamStateChange.Defense:
               break;
            default:
               throw new ArgumentOutOfRangeException("changeType");
         }
      }
   }
}