namespace FactoryPatternExample
{
public class NflBalancedFootballTeam : FootballTeam
{
   private const int ROSTER_SIZE = 53;

   public NflBalancedFootballTeam( /*string name, string coach, int rosterSize*/)
      : base(ROSTER_SIZE)
   {
      Name = "[Balanced NFL Team]";
      HeadCoach = "Balanced NFL Coach";
   }
}
}