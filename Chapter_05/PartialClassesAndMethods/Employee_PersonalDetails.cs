using System.Security;

namespace PartialClassesAndMethods
{
  public partial class Employee
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // This method is defined in this class, but not implemented
    // The method has been implemented in 'Employee_JobDetails.cs' to showcase partial methods within partial
    // By documentation, partial method must always return void, and cannot have 'out' parameters. 'ref' is allowed since C# 9
    partial void OnJobAssigned(string firstName, string lastName);
  }
}
