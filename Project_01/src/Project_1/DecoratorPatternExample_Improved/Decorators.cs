using System;

namespace DecoratorPatternExample_Improved
{
public class _1Te : IOffensiveBehavior
{
   private readonly IOffensiveBehavior _offensiveBehavior;

   public _1Te(IOffensiveBehavior behavior)
   {
      _offensiveBehavior = behavior;
   }

   public string RunPlay()
   {
      return _offensiveBehavior.RunPlay() + ".1TE";
   }
}

public class _2Te : IOffensiveBehavior
{
   private readonly IOffensiveBehavior _offensiveBehavior;

   public _2Te(IOffensiveBehavior behavior)
   {
      _offensiveBehavior = behavior;
   }

   public string RunPlay()
   {
      return _offensiveBehavior.RunPlay() + ".2TE";
   }
}

public class _1Rb : IOffensiveBehavior
{
   private readonly IOffensiveBehavior _offensiveBehavior;

   public _1Rb(IOffensiveBehavior behavior)
   {
      _offensiveBehavior = behavior;
   }

   public string RunPlay()
   {
      return _offensiveBehavior.RunPlay() + ".1RB";
   }
}

public class _3Rb : IOffensiveBehavior
{
   private readonly IOffensiveBehavior _offensiveBehavior;

   public _3Rb(IOffensiveBehavior behavior)
   {
      _offensiveBehavior = behavior;
   }

   public string RunPlay()
   {
      return _offensiveBehavior.RunPlay() + ".3RB";
   }
}

public class _3Wr : IOffensiveBehavior
{
   private readonly IOffensiveBehavior _offensiveBehavior;

   public _3Wr(IOffensiveBehavior behavior)
   {
      _offensiveBehavior = behavior;
   }

   public string RunPlay()
   {
      return _offensiveBehavior.RunPlay() + ".3WR";
   }
}

public class _4Wr : IOffensiveBehavior
{
   private readonly IOffensiveBehavior _offensiveBehavior;

   public _4Wr(IOffensiveBehavior behavior)
   {
      _offensiveBehavior = behavior;
   }

   public string RunPlay()
   {
      return _offensiveBehavior.RunPlay() + ".4WR";
   }
}

public class Shotgun : IOffensiveBehavior
{
   private readonly IOffensiveBehavior _offensiveBehavior;

   public Shotgun(IOffensiveBehavior behavior)
   {
      _offensiveBehavior = behavior;
   }

   public string RunPlay()
   {
      return _offensiveBehavior.RunPlay() + ".Shotgun";
   }
}

public class Pistol : IOffensiveBehavior
{
   private readonly IOffensiveBehavior _offensiveBehavior;

   public Pistol(IOffensiveBehavior behavior)
   {
      _offensiveBehavior = behavior;
   }

   public string RunPlay()
   {
      return _offensiveBehavior.RunPlay() + ".Pistol";
   }
}

public class Wishbone : IOffensiveBehavior
{
   private readonly IOffensiveBehavior _offensiveBehavior;

   public Wishbone(IOffensiveBehavior behavior)
   {
      _offensiveBehavior = behavior;
   }

   public string RunPlay()
   {
      return _offensiveBehavior.RunPlay() + ".Wishbone";
   }
}
}