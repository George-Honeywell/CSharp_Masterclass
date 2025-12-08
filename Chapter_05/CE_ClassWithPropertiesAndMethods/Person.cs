namespace CE_ClassWithPropertiesAndMethods
{
  internal class Person
  {
    // Private field to store the name
    private string _name;
    // Private field to store the age
    private int _age;

    // Public property for the name
    public string Name 
    { 
      get { return _name; } 
      set { _name = value; }
    }

    // Public property for the age
    public int Age
    {
      get { return _age; } // Getter for the age
      set
      {
        if (value >= 0) // Checking if the age value is greater than 0
          _age = value; // Setting the value of age if the condition is true
        else
          Console.WriteLine("Age cannot be below 0!");        
      }
    }

    public Person(string name, int age)
    {
      // Assigning the name to the private field _name
      _name = name;
      
      // Assigning the age using the property to ensure the value is valid
      Age = age;
    }

    public void GreetPerson()
    {
      Console.WriteLine($"Welcome, {Name}! You're {Age} years old!");
    }
  }
}
