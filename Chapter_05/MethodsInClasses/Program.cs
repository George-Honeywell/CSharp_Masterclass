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

      // As the customer 'andy' doesn't have any details assigned at initialization
      // The 'SetCustomerDetails' method can be called, in which we pass in the details we want to set
      andy.SetCustomerDetails("Andy", "United Kingdom", 987654321);

      // As no information is passed in the first time round, we print the details again to check they've been updated correctly
      andy.GetCustomerDetails();
    }
  }
}
