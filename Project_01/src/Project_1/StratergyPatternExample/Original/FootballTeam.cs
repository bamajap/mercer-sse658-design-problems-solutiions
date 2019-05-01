using System;

namespace StratergyPatternExample.Original
{
   public class FootballTeam
   {
      protected readonly int _rosterSize;

      private string _name;

      public string Name
      {
         get { return string.Format("[{0}]", _name); }
         private set { _name = value; }
      }

      private FootballTeam()
      {
      }

      public FootballTeam(string name, int size)
      {
         Name = name;
         _rosterSize = size;
      }

      #region Offensive Behavior

      /// <summary>
      /// Determines if the offense should execute a running play.
      /// </summary>
      private bool _timeForRunPlay = true;

      public void RunOffensivePlay(OffensivePlay play)
      {
         switch (play)
         {
            case OffensivePlay.Balanced:
               break;
            case OffensivePlay.PassHappy:
               _timeForRunPlay = false;
               break;
            case OffensivePlay.BallControl:
               _timeForRunPlay = true;
               break;
            default:
               throw new ArgumentOutOfRangeException("play");
         }
         RunBalancedPlay();
      }

      private void RunBalancedPlay()
      {
         var msg = (_timeForRunPlay) ? "Ran a running play..." : "Ran a passing play...";
         Console.WriteLine(msg);
         _timeForRunPlay = !_timeForRunPlay;
      }

      #endregion // Offensive Behavior
   }

   public enum OffensivePlay
   {
      Balanced,
      PassHappy,
      BallControl
   }
}