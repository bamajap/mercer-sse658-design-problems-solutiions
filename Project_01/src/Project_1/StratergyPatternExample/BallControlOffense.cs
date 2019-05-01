using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StratergyPatternExample
{
public class BallControlOffense : IOffensiveBehavior
{
   public void RunPlay()
   {
      Console.WriteLine("Ran a running play...");
   }
}
}