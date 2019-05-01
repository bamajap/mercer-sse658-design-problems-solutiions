using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternExample
{
public interface ITeamObservable
{
   void Register(ITeamObserver observer);
   void Unregister(ITeamObserver observer);
   void NotifyListeners(TeamStateChange changeType);
}
}