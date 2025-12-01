namespace InnerClasses
{
  public class OuterClassTwo
  {
    private string outerField = "I belong to OuterClassTwo";

    public class InnerClassTwo
    {
      private OuterClassTwo outer;

      public InnerClassTwo(OuterClassTwo o)
      {
        this.outer = o;
      }

      public void DisplayOuterField()
      {
        Console.WriteLine(outer.outerField);
      }
    }
  }
}
