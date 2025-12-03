namespace PublicAndPrivateKeywords
{
  // Access Modifiers
  // public - Any method, class, field, variable etc. marked as 'public' can be accessed in any class
  // private - Any method, class, field, variable etc. marked as 'private' can only be accessed within the class it's defined in
  internal class Customer
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Country { get; set; }
    // Age will not be able to be accessed in any other class.
    private int _Age { get; set; }

    public Customer()
    {
      Console.WriteLine("new customer created with no information. Ensure information is added as soon as possible.");
    }

    private string GetCustomerName()
    {
      return FirstName + " " + LastName;
    }
  }
}
