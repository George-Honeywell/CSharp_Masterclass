namespace MethodsInClasses
{
  internal class Program
  {
    public static void Main()
    {
      // Uses the Constructor which accepts 3 arguments
      Customer george = new Customer("George", "United Kingdom", 123456789);
      george.GetCustomerDetails();

      // Uses the Constructor which only accepts 1 argument
      Customer jack = new Customer("Jack");
      jack.GetCustomerDetails();

      // Uses the Default Constructor with no arguments required
      Customer andy = new Customer();
      andy.GetCustomerDetails();
    }
  }
}
