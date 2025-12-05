namespace IdKeyAndReadonly
{
  internal class Customer
  {
    // Static field to hold the next available ID
    private static int customerId = 0;

    // A field marked with 'readonly' can only be initialized in the classes constructor
    // Cannot be assigned to after the constructor exists
    // Can be assigned and reassigned multiple times within the field declaration and constructor
    // Once the constructor has finished executing, the field becomes immutable 
    private readonly int _id;

    // Read-Only Properties
    // Using only 'get', it allows the field only to be read from
    // As there is not 'set', this value cannot be changed
    public int Id { get { return _id; } }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Customer(string firstName, string lastName)
    {
      _id = customerId++;
      FirstName = firstName;
      LastName = lastName;
    }

    public void GetCustomerDetails()
    {
      Console.WriteLine("--- Customer Details ---");
      Console.WriteLine($"Customer ID: {_id}");
      Console.WriteLine($"First Name: {FirstName}");
      Console.WriteLine($"Last Name : {LastName}");
    }
  }
}
