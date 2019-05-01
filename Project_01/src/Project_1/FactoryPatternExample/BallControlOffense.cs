using System;
using FactoryPatternExample.Interfaces;

namespace FactoryPatternExample
{
   public class BallControlOffense : IOffensiveBehavior
   {
      public void RunPlay()
      {
         Console.WriteLine("Ran a running play...");
      }
   }
}