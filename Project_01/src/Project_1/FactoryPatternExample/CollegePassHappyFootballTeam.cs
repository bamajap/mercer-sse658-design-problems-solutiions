namespace FactoryPatternExample
{
public class CollegePassHappyFootballTeam : FootballTeam
{
   private const int ROSTER_SIZE = 85;
   // Another concrete class...
   public CollegePassHappyFootballTeam()
      : base(ROSTER_SIZE)
   {
      Name = "[PassHappy College Team]";
      HeadCoach = "PassHappy College Coach";
   }
}
}