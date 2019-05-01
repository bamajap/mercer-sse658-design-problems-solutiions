using System;

namespace EventPatternExample
{
   public class PassHappyOffense : IOffensiveBehavior
   {
      public void RunPlay()
      {
         Console.WriteLine("Ran a passing play...");
      }
   }
}