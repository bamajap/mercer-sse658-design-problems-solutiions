using System;

namespace EventPatternExample
{
   class IllegalOffense:IOffensiveBehavior
   {
      public void RunPlay()
      {
         Console.WriteLine("ILLEGAL OFFENSE!!!");
      }
   }
}
