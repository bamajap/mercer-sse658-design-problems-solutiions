namespace FactoryPatternExample
{
   public class NflPassHappyFootballTeam : FootballTeam
   {
      private const int ROSTER_SIZE = 53;

      public NflPassHappyFootballTeam()
         : base(ROSTER_SIZE)
      {
         Name = "[PassHappy NFL Team]";
         HeadCoach = "PassHappy NFL Coach";
      }
   }
}