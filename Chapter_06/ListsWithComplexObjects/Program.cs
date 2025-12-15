namespace ListsWithComplexObjects
{
  public class Exercises
  {
    public string Name { get; set; }
    public int MaxWeightKg { get; set; }

    public Exercises(string name, int maxWeightKg)
    {
      Name = name;
      MaxWeightKg = maxWeightKg;
    }

    public Exercises() { }
  }

  internal class Program
  {
    static List<Exercises> exercises = new List<Exercises>();
    static void Main(string[] args)
    {
      // Adding new items if a constructor exists
      exercises.Add(new Exercises ( "Bench Press", 60 ));

      // Adding new items if a constructur doesn't exist
      exercises.Add(new Exercises { Name = "Barbell Back Squat", MaxWeightKg = 100 });

      // Test adding a custom exercise
      Console.Write("Enter a name for a exercise: ");
      string exerciseName = Console.ReadLine();

      Console.Write("Enter the maximum weight used for the exercise (kg): ");
      int exerciseWeight = Convert.ToInt32(Console.ReadLine());
      AddExercise(exerciseName, exerciseWeight);

      // Print out the contents of the List
      Console.WriteLine("Exercises in Database: ");
      foreach(var exercise in exercises)
      {
        Console.WriteLine($"Name: {exercise.Name} - Max Weight (kg): {exercise.MaxWeightKg}");
      }
    }

    public static void AddExercise(string name, int maxWeightKg)
    {
      exercises.Add(new Exercises(name, maxWeightKg));
    }
  }
}
