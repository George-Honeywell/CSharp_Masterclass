namespace StaticKeyword
{
  internal class Customer
  {
    public string Name { get; set; }
    public string Country { get; set; }
    public int ContactNumber { get; set; }

    // Static field to track the amount of instances of the Customer class have been created
    public static int NumberOfCustomers = 0;

    // Default Constructor
    public Customer()
    {
      Name = "<No Name Set>";
      Country = "<No Country Set>";
      ContactNumber = 0;

      // Increase the counter in the constructors 
      NumberOfCustomers++;
    }

    // Custom Constructor
    public Customer(string name, string country, int contactNumber)
    {
      Name = name;
      Country = country;
      ContactNumber = contactNumber;

      NumberOfCustomers++;
    }

    public Customer(string name)
    {
      Name = name;
      NumberOfCustomers++;
    }

    public void SetCustomerDetails(string name, string country, int contactNum)
    {
      Name = name;
      Country = country;
      ContactNumber = contactNum;
    }

    public static void GetCustomerCount()
    {
      Console.WriteLine($"There are a total of {NumberOfCustomers} Customer Record(s) in the database.");
    }
  }
}
