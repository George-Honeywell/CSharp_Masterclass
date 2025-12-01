namespace PartialClassesAndMethods
{
  public partial class Employee
  {
    public string JobTitle { get; set; }
    public double Salary { get; set; }

    // Implementation of the 'OnJobAssigned' method
    partial void OnJobAssigned(string firstName, string lastName)
    {
      // Passing in the first name and last name of the employee. As 'JobTitle' is within this class, no need to pass it as a parameter
      Console.WriteLine($"The job title for {firstName} {lastName} has been updated. Their new job title is: {JobTitle}");
    }

    public void AssignNewTitle(string title, double salary)
    {
      this.JobTitle = title;
      this.Salary = salary;
      OnJobAssigned("George", "Honeywell");
    }
  }
}
