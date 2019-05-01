using System;

namespace AbstractFactoryPatternExample
{
   public class PassHappyOffense : IOffensiveBehavior
   {
      public void RunPlay()
      {
         Console.WriteLine("Ran a passing play...");
      }
   }
}