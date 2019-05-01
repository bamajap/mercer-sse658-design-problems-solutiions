using System;

namespace EventPatternExample
{
   public class BalancedDefense:IDefensiveBehavior
   {
      public void DefendPlay()
      {
         Console.WriteLine("Defending play with balanced defense.");
      }
   }
}
