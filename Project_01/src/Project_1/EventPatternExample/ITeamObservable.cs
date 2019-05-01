namespace EventPatternExample
{
public interface ITeamObservable
{
   void Register(ITeamObserver observer);
   void Unregister(ITeamObserver observer);
   void NotifyListeners(TeamStateChange changeType);
}
}