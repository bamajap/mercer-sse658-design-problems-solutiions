using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternExample
{
   class IllegalOffense:IOffensiveBehavior
   {
      public void RunPlay()
      {
         Console.WriteLine("ILLEGAL OFFENSE!!!");
      }
   }
}
