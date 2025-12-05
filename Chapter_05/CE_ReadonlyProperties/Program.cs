namespace CE_ReadonlyProperties
{
  public class Exercise
  {
    // Create a 'private readonly string'
    private readonly string _message = "";
    // Create a public read only property, which is defined by the 'get' with no 'set' available
    public string Message { get { return _message; } }

    // In the constructor, set the value of the 'readonly' field to whatever is passed into the constructor
    public Exercise(string val)
    {
      _message = val; 
    }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      Exercise ex = new Exercise("This is a 'Read-Only' Property!");
      Console.WriteLine(ex.Message);
    }
  }
}
