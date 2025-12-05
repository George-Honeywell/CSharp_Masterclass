namespace ConstAndReadonly
{
  internal class Rectangle
  {
    // 'const' and 'readonly' are two keywords that are used to define non-modifiable fields
    // For extra clarification
    // Immutable - means an objects state cannot be changed after it has been initialized
    // Mutable - means an objects state can be changed after it has been initialized

    // 'const' means that a variable/fields value cannot be changed once initialized. 
    // If the variable is reassigned another value, the compiler will throw an error
    // 'const' needs to be initialized during compile-time
    // The same for all instances of this class
    public const int NumberOfCorners = 4;

    // A different colour can be assigned in the constructor for different instances
    public readonly string Colour;
    
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area { get { return Math.Round(Width * Height, 2); }  }

    public Rectangle(string colour, double width, double height)
    {
      // 'Colour' can only be set in the constructor as it's marked as 'readonly'
      Colour = colour;
      Width = width;
      Height = height;
    }

    public void DisplayRectangle()
    {
      Console.WriteLine($"Colour: {Colour}, Width: {Width}, Height: {Height}, Area: {Area}, Number of Corners: {NumberOfCorners}.");
    }
  }
}
