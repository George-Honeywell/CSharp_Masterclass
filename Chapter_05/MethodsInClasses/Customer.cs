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

    private static int Count = 0;

    // Default Constructor
    public Customer()
    {
      Name = "<No Name Set>";
      Country = "<No Country Set>";
      ContactNumber = 0;
      Count++;
    }

    // Custom Constructor
    public Customer(string name, string country, int contactNumber)
    {
      Name = name;
      Country = country;
      ContactNumber = contactNumber;
      Count++;
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
  }
}
