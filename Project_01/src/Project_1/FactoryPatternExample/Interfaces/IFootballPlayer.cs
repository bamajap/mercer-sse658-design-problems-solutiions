namespace FactoryPatternExample
{
   public interface IFootballPlayer : IPerson
   {
      // All values below are on a scale of 1-100
      int Speed { get; set; }
      int Strength { get; set; }
      int Stamina { get; set; }
   }
}