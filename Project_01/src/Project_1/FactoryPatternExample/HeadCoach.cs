namespace FactoryPatternExample
{
   public class HeadCoach : IPerson
   {
      public string Name { get; set; }
      public int Height { get; set; }
      public int Weight { get; set; }

      private HeadCoach()
      {
      }

      public HeadCoach(string name)
      {
         Name = name;
      }
   }
}