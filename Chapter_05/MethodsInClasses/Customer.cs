using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsInClasses
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

    // Defined methods within the class which allow the class to display information
    // Methods can be used to change the state of a class too
    // This method can get the information for EACH instance of the class
    public void GetCustomerDetails()
    {
      Console.WriteLine("--- CUSTOMER DETAILS ---");
      Console.WriteLine($"\tName: {Name}\n\tCountry: {Country}\n\tContact Number: {ContactNumber}\n");
    }

    // With instances of the class that don't have any information filled out at the time of initialization
    // we can use another method to fill these out. Constructors are only run once, so the constructor cannot be called again on the same instance
    // This method can be called on each instance itself
    // Marked as 'public' so it can be accessed from another class
    public void SetCustomerDetails(string name, string country, int contactNumber)
    {
      Name = name;
      Country = country;
      ContactNumber = contactNumber;
    }
  }
}
