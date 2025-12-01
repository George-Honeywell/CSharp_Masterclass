namespace OperatorOverloading
{
  // Operator Overloading is a feature in C# (and other languages) that allows the developer to redefine the behavior of operators for customer classes and structs
  // By default operators like +, -, *, / work with build in types such as int, double, float, and string. 
  // However, if the developer creates a custom class (Vector, Matrix, Quaternion, etc), C# does not automatically define how these operators should behave
  // Operator overloading allows the operator to have it's functionality extended so standard operators can work with custom types
  // To overload an operator, the 'operator' keyword must be used
  // The method also needs to be marked as 'static' (covered later on)
  // Below is the basic syntax

  /*
   * public static ReturnType operator Symbol(Type1 operand1, Type2 operand2)
   * {
   *    // define custom behavior
   *    return res;
   * }  
   */

  // Define a custom type

  public class Vector
  {
    public int X { get; set; }
    public int Y { get; set; }
    
    public Vector(int x, int y)
    {
      X = x;
      Y = y;
    }

    public void DisplayVec()
    {
      Console.WriteLine($"Vector: x:{X}, y:{Y}");
    }

    // Define how to Vector objects should be added together
    public static Vector operator +(Vector a, Vector b)
    {
      return new Vector(a.X + b.X, a.Y + b.Y);
    }

    // Custom operator overloads for practice
    public static Vector operator -(Vector a, Vector b)
    {
      return new Vector(a.X - b.X, a.Y - b.Y);
    }

    public static bool operator ==(Vector a, Vector b)
    {
      if (a.X == b.X && a.Y == b.Y)
        return true;
      else
        return false;
    }

    public static bool operator !=(Vector a, Vector b)
    {
      if (a.X != b.X || a.Y != b.Y)
        return true;
      else
        return false;
    }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      Vector vec1 = new Vector(10, 30);
      vec1.DisplayVec();

      Vector vec2 = new Vector(10, 30);
      vec2.DisplayVec();

      Vector result = vec1 + vec2;
      result.DisplayVec();

      // Should return TRUE is both vec1 and vec2 contain the same value
      bool isVectorEqual = vec1 == vec2;
      Console.WriteLine(isVectorEqual);

      // Should return FALSE is vec1 and vec2 contain different values for both X and Y
      bool isVectorNotEqual = vec1 != vec2;
      Console.WriteLine(isVectorNotEqual);
    }
  }
}
