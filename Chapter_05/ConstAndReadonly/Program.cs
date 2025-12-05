namespace ConstAndReadonly
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Rectangle rect1 = new Rectangle("Blue", 25.4, 32.8);
      rect1.DisplayRectangle();

      Rectangle rect2 = new Rectangle("Green", 5, 6);
      rect2.DisplayRectangle();
    }
  }
}
