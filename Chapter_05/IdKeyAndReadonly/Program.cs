namespace IdKeyAndReadonly
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Customer ghoneywell = new Customer("George", "Honeywell");
      ghoneywell.GetCustomerDetails();

      Customer atomline = new Customer("Andy", "Tomline");
      atomline.GetCustomerDetails();
    }
  }
}
