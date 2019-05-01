namespace AbstractFactoryPatternExample
{
public class NflTeamCreationCriteriaAbstractFactory : ITeamCreationCriteriaAbstractFactory
{
   public int RosterSize
   {
      get { return 53; }
   }

   public string Name { get; private set; }

   public string HeadCoach { get; private set; }

   public NflTeamCreationCriteriaAbstractFactory(OffensiveType type)
   {
      HeadCoach = string.Format("{0} {1}", type, "NFL Coach");
      Name = string.Format("[{0} NFL Team]", type);
   }
}
}