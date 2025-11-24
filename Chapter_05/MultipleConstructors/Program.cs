namespace MultipleConstructors
{
  internal class Program
  {
    static void Main()
    {
      // Uses the Constructor which accepts 3 arguments
      Customer george = new Customer("George", "United Kingdom", 123456789);
      Console.WriteLine("--- CUSTOMER DETAILS ---");
      Console.WriteLine($"\tName: {george.Name}\n\tCountry: {george.Country}\n\tContact Number: {george.ContactNumber}");

      // Uses the Constructor which only accepts 1 argument
      Customer jack = new Customer("Jack");
      Console.WriteLine("--- CUSTOMER DETAILS ---");
      Console.WriteLine($"\tName: {jack.Name}\n\tCountry: {jack.Country}\n\tContact Number: {jack.ContactNumber}");

      // Uses the Default Constructor with no arguments required
      Customer andy = new Customer();
      Console.WriteLine("--- CUSTOMER DETAILS ---");
      Console.WriteLine($"\tName: {andy.Name}\n\tCountry: {andy.Country}\n\tContact Number: {andy.ContactNumber}");

    }
  }
}
