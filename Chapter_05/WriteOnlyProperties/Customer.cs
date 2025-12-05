namespace WriteOnlyProperties
{
  internal class Customer
  {
    private static int nextId = 0;
    private readonly int _id;
    private string _password;
    // Write only Property
    public string Password { set { _password = value; } }
    public int Id { get { return _id; } }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Country { get; set; }

    public Customer(string firstName, string lastName, string country = "<Not Set>")
    {
      _id = nextId++;
      FirstName = firstName;
      LastName = lastName;
      Country = country;
    }

    public Customer(string firstName, string lastName)
    {
      _id = nextId++;
      FirstName = firstName;
      LastName = lastName;
    }

    public void GetCustomerId()
    {
      Console.WriteLine($"The customers unique ID is: {_id}");
    }
  }
}
