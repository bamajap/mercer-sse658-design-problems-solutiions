namespace FactoryPatternExample.Interfaces
{
public interface IFootballTeamFactory
{
   FootballTeam Create(OffensiveType type);
}
}