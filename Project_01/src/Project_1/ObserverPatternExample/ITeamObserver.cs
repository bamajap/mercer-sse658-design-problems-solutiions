using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternExample
{
public interface ITeamObserver
{
   void Update(FootballTeam footballTeam, TeamStateChange changeType);
}
}
