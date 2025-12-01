namespace PartialClassesAndMethods
{

  // Partial Classes allow a class definition to be split across multiple files
  // Particulary useful in large projects where different developers might work on different aspects of the same class
  // Partical Methods enable the declaration of method signatures in one part of the class while allowing the implementation to be optional in another

  // When to use Partial Classes
  // - Large projects where multiple developers work on the same class
  // - Auto-generated code that needs extension without modification
  // - Keeping related functionalities separate for better organization

  // When to use Partial Methods
  // - When defining optional hooks that subclasses may implement
  // - For auto-generated code where an optional implementation can be provided later
  // - Reducing unnecessary code execution if no implementation is needed

  // Common Mistakes
  // - Overusing partial classes when not needed, leading to fragmentation
  // - Forgetting to declare 'partial' in both class files
  // - Trying to return values from partial methods, they MUST be void
  internal class Program
  {
    static void Main(string[] args)
    {
      Employee emp = new Employee();
      emp.FirstName = "George";
      emp.LastName = "Honeywell";
      emp.JobTitle = "C# Developer I";
      emp.Salary = 40000;

      Console.WriteLine($"{emp.FirstName} {emp.LastName} works as a {emp.JobTitle} with a salary of £{emp.Salary}");
      emp.AssignNewTitle("C# Developer II", 50000);
    }
  }
}
