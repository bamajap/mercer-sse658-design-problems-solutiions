using System;
using System.IO;
using DecoratorPatternExample;
using FactoryPatternExample;
using ObserverPatternExample;
using StratergyPatternExample;
using AbstractFactoryPatternExample;
using EventPatternExample;
using DecoratorPatternExample_Improved;

namespace Project_1_Simulator
{
   class Program
   {
      static void Main()
      {
         var consoleOut = Console.Out;
         Console.SetOut(File.CreateText("log.txt"));

         var nL = Environment.NewLine;
         var repeat = true;

         do
         {
            Console.Write("1 - Demonstrate Strategy Design Pattern." + nL +
                          "2 - Demonstrate Observer Design Pattern." + nL +
                          "3 - Demonstrate Decorator Design Pattern." + nL +
                          "4 - Demonstrate Factory Design Pattern." + nL);

            var key = Console.ReadKey();

            Console.WriteLine(nL);

            switch (key.KeyChar)
            {
               case '1':
                  StrategyPatternSim.Run();
                  break;
               case '2':
                  ObserverPatternSim.Run();
                  EventPatternSim.Run();
                  break;
               case '3':
                  NonDecoratorPatternSim.Run();
                  DecoratorPatternSim.Run();
                  break;
               case '4':
                  FactoryPatternSim.Run();
                  AbstractFactoryPatternSim.Run();
                  break;
               default:
                  repeat = false;
                  break;
            }
            Console.WriteLine(nL);
         } while (repeat);

         Console.SetOut(consoleOut);
      }
   }
}
