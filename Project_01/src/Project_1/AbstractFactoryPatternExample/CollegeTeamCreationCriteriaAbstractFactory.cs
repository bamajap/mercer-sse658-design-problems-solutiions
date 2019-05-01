namespace AbstractFactoryPatternExample
{
public class CollegeTeamCreationCriteriaAbstractFactory :
   ITeamCreationCriteriaAbstractFactory
{
   public int RosterSize
   {
      get { return 85; }
   }

   public string Name { get; private set; }

   public string HeadCoach { get; private set; }

   public CollegeTeamCreationCriteriaAbstractFactory(OffensiveType type)
   {
      HeadCoach = string.Format("{0} {1}", type, "College Coach");
      Name = string.Format("[{0} College Team]", type);
   }
}
}