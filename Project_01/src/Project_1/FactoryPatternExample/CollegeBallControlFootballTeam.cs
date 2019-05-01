using System;

namespace FactoryPatternExample
{
   public class CollegeBallControlFootballTeam : FootballTeam
   {
      private const int ROSTER_SIZE = 85;

      public CollegeBallControlFootballTeam():base(ROSTER_SIZE)
      {
         Name = "[BallControl College Team]";
         HeadCoach = "BallControl College Coach";
      }
   }
}