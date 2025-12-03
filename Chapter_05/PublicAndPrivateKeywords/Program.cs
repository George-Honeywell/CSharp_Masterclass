namespace PublicAndPrivateKeywords
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Customer ghoneywell = new Customer();

      // Using the public fields to set values for the new customer
      ghoneywell.FirstName = "George";
      ghoneywell.LastName = "Honeywell";
      ghoneywell.Country = "United Kingdom";

      // As '_Age' is marked as private, it cannot be accessed here
      // Inaccessible due to it's protection level
      // ghoneywell._Age = 32;

      // The same applies to methods too
      // Inaccessible due to it's protection level
      // ghoneywell.GetCustomerName();
    }
  }
}
