namespace IntroductionIntoClasses
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Creating an instance of the Car Class
      Car toyota = new Car("Toyota", "CH-R", false);
      Car polestar = new Car("Polestar", "4", true);

      Console.Write("Enter a model: ");
      polestar.Model = Console.ReadLine();
      Console.WriteLine(polestar.Model);

      Console.Write("Enter a model: ");
      toyota.Model = Console.ReadLine();
      Console.WriteLine(toyota.Model);
    }
  }
}
