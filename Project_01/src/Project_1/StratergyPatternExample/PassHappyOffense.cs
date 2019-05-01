using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StratergyPatternExample
{
public class PassHappyOffense : IOffensiveBehavior
{
   public void RunPlay()
   {
      Console.WriteLine("Ran a passing play...");
   }
}
}