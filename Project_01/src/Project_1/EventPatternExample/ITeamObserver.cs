namespace EventPatternExample
{
public interface ITeamObserver
{
   void Update(FootballTeam footballTeam, TeamStateChange changeType);
}
}
