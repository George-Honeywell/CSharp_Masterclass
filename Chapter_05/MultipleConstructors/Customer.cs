using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleConstructors
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
  }
}
