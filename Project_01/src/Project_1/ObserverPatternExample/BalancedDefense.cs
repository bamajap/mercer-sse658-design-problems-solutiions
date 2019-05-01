using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternExample
{
   public class BalancedDefense:IDefensiveBehavior
   {
      public void DefendPlay()
      {
         Console.WriteLine("Defending play with balanced defense.");
      }
   }
}
