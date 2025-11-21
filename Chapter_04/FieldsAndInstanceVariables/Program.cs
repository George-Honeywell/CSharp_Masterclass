namespace FieldsAndInstanceVariables
{
  internal class Program
  {
    // As the variable is declared in the class and not a method, it's a 'field'
    // This can be used throughout the class
    static int returnValue;

    static void Main(string[] args)
    {
      returnValue = Add(5, 5);
      Console.WriteLine($"5 + 5 = {returnValue}");

      returnValue = Subtract(5, 5);
      Console.WriteLine($"5 - 5 = {returnValue}");
    }

    static int Add(int a, int b)
    {
      return a + b;
    }

    static int Subtract(int a, int b)
    {
      return a - b;
    }
  }
}
