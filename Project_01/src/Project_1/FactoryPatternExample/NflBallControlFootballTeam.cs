namespace FactoryPatternExample
{
   public class NflBallControlFootballTeam : FootballTeam
   {
      private const int ROSTER_SIZE = 53;

      public NflBallControlFootballTeam()
         : base(ROSTER_SIZE)
      {
         Name = "[BallControl NFL Team]";
         HeadCoach = "BallControl NFL Coach";
      }
   }
}