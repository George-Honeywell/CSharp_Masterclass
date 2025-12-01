namespace StaticKeyword
{
  internal class Customer
  {
    public string Name { get; set; }
    public string Country { get; set; }
    public int ContactNumber { get; set; }

    // Default Constructor
    public Customer()
    {
      Name = "<No Name Set>";
      Country = "<No Country Set>";
      ContactNumber = 0;
    }

    // Custom Constructor
    public Customer(string name, string country, int contactNumber)
    {
      Name = name;
      Country = country;
      ContactNumber = contactNumber;
    }

    public Customer(string name)
    {
      Name = name;
    }

    public void SetCustomerDetails(string name, string country, int contactNum)
    {
      Name = name;
      Country = country;
      ContactNumber = contactNum;
    }

    public static void GetCustomerCount()
    {
      Console.WriteLine("This method is static and therefore can be called without being created by an instance of the Customer object.");
    }
  }
}
