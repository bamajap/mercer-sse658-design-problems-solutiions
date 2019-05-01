namespace FactoryPatternExample
{
   public interface IPerson
   {
      string Name { get; set; }
      int Height { get; set; } // in inches
      int Weight { get; set; } // in pounds
   }
}