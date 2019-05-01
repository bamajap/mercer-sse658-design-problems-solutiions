namespace FactoryPatternExample
{
public class CollegeBalancedFootballTeam : FootballTeam
{
   private const int ROSTER_SIZE = 85;

   public CollegeBalancedFootballTeam( /*string name, string coach, int rosterSize*/)
      : base(ROSTER_SIZE)
   {
      Name = "[Balanced College Team]";
      HeadCoach = "Balanced College Coach";
   }
}
}