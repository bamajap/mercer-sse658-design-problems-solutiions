using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using StratergyPatternExample;

namespace StratergyPatternExampleTests
{
   [TestFixture]
   public class FootballPlayerTests
   {
      [Test]
      public void FootballPlayerCanBeCreated_Test()
      {
         var footballPlayer = new FootballPlayer();
         Assert.IsNotNull(footballPlayer);
      }
   }
}