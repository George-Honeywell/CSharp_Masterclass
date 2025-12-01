namespace OptionalParameters
{
  public class Customer
  {
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? Age { get; set; }
    public string? Country { get; set; }

    // Optional Parameters 
    // An optional parameter means it's a parameter that doesn't need to be specified when creating a new instance of a class, or passing arguments to a method
    // The constructor below shows an example of an optional parameter for the country
    // If no country is given, 'NA' will simply be returned
    public Customer(string firstName = "NA", string lastName = "NA", int age = 0, string country = "NA")
    {
      FirstName = firstName;
      LastName = lastName;
      Age = age;
      Country = country;
    }

    public void UpdateCustomerDetails(string firstName, string lastName, int age, string country = "NA")
    {
      FirstName = firstName;
      LastName = lastName;
      Age = age;
      Country = country;
    }

    public void PrintCustomerDetails()
    {
      Console.WriteLine($"{FirstName} {LastName} {Age} {Country}");
    }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      // No value given for the country, so returns NA
      Customer georgeh = new Customer("George", "Honeywell", 32);
      georgeh.PrintCustomerDetails();

      // 'United Kingdom' given for the Country, so will return 'United Kingdom'
      Customer andyt = new Customer("Andy", "Tomline", 29, "United Kingdom");
      andyt.PrintCustomerDetails();

      // Named Parameters
      Customer vecna = new Customer();

      // For methods, functions, constructors, etc. that have multiple parameters, using the Named Parameters allows the name to be defined and the value assigned to it
      // Particularly useful if a method has 10+ parameters (for example)
      vecna.UpdateCustomerDetails(firstName: "Vecna", lastName: "?", age: 100, country: "Upside Down");
      vecna.PrintCustomerDetails();


    }
  }
}
