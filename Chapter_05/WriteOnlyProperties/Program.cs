namespace WriteOnlyProperties
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Customer ghoneywell = new Customer("George", "Honeywell");
      ghoneywell.GetCustomerId();

      Customer atomline = new Customer("Andy", "Tomline");
      atomline.GetCustomerId();

      // As this property only contains 'set', this property can only have it's value set
      atomline.Password = "qwerty";
      // Console.WriteLine(atomline.Password); // CS0154 : Property does not contain an accessor 'get' and cannot be used in this context
    }
  }
}
