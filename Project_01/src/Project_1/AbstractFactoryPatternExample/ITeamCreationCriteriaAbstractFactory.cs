namespace AbstractFactoryPatternExample
{
public interface ITeamCreationCriteriaAbstractFactory
{
   int RosterSize { get; }
   string Name { get; }
   string HeadCoach { get; }
}
}