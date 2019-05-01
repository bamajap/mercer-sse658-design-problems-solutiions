using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternExample
{
class OfficiatingCrew:ITeamObserver
{
   public void Update(FootballTeam footballTeam, TeamStateChange changeType)
   {
      switch (changeType)
      {
         case TeamStateChange.Offense:
            if(footballTeam.OffensiveBehavior is IllegalOffense)
               Console.WriteLine("\tPENALTY!! --> The offense is illegal!");
            else
               Console.WriteLine("The officiating crew has OK'd this offense.");
            break;
         case TeamStateChange.Defense:
            // Respond to defensive changes
            break;
         default:
            throw new ArgumentOutOfRangeException("changeType");
      }
   }
}
}
