namespace DecoratorPatternExample_Improved
{
public class NflOffense : IOffensiveBehavior
{
   public string RunPlay()
   {
      return "NFL";
   }
}

public class CollegeOffense : IOffensiveBehavior
{
   public string RunPlay()
   {
      return "College";
   }
}

public class HighSchoolOffense : IOffensiveBehavior
{
   public string RunPlay()
   {
      return "HighSchool";
   }
}
}