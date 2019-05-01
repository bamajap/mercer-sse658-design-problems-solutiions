using System;

namespace EventPatternExample
{
   public class BalancedOffense : IOffensiveBehavior
   {
      private bool _timeForRunPlay = true;

      public void RunPlay()
      {
         var msg = (_timeForRunPlay) ? "Ran a running play..." : "Ran a passing play...";
         Console.WriteLine(msg);
         _timeForRunPlay = !_timeForRunPlay;
      }
   }
}