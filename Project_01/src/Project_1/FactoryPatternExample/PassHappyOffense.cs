using System;
using FactoryPatternExample.Interfaces;

namespace FactoryPatternExample
{
   public class PassHappyOffense : IOffensiveBehavior
   {
      public void RunPlay()
      {
         Console.WriteLine("Ran a passing play...");
      }
   }
}