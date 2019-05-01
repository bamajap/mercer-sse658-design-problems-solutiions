using System;

namespace AbstractFactoryPatternExample
{
   public class BallControlOffense : IOffensiveBehavior
   {
      public void RunPlay()
      {
         Console.WriteLine("Ran a running play...");
      }
   }
}