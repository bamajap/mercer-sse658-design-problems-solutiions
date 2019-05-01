using System;

namespace DecoratorPatternExample
{
   public class CollegePistol3Wr1Rb1TeOffense : IOffensiveBehavior
   {
      public void RunPlay()
      {
         var msg = "The College.Pistol.3WR.1RB.1TE offense ran a play...";
         Console.WriteLine(msg);
      }
   }

   public class NflShotgun4Wr1RbOffense : IOffensiveBehavior
   {
      public void RunPlay()
      {
         var msg = "The NFL.Shotgun.4WR.1RB offense ran a play...";
         Console.WriteLine(msg);
      }
   }
   
   public class HighSchoolWishbone3Rb2TeOffense : IOffensiveBehavior
   {
      public void RunPlay()
      {
         var msg = "The HighSchool.Wishbone.3RB.2TE offense ran a play...";
         Console.WriteLine(msg);
      }
   }
}