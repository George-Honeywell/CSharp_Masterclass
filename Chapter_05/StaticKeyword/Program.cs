namespace StaticKeyword
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // The 'SetCustomerDetails' method can only be called on an object instance of 'Customer' as it's not marked as static
      Customer customer = new Customer();
      customer.SetCustomerDetails("George", "United Kingdom", 123456789);

      // If a method is marked as 'static', the method must be called on the class, not an instance
      // As 'GetCustomerCount()' is marked as static, it can be called from the class directly
      // Note: Any methods marked as static don't belong to a single instance of a class
      // Attempting to call 'GetCustomerCount()' from an object instance will result in a compile-time error
      Customer.GetCustomerCount();
    }
  }
}
