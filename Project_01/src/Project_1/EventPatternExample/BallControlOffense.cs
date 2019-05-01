using System;

namespace EventPatternExample
{
   public class BallControlOffense : IOffensiveBehavior
   {
      public void RunPlay()
      {
         Console.WriteLine("Ran a running play...");
      }
   }
}