using System;

namespace ObserverPatternExample
{
   public class BallControlOffense : IOffensiveBehavior
   {
      public void RunPlay()
      {
         Console.WriteLine("Ran a running play...");
      }
   }
}