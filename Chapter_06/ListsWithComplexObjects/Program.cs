namespace ListsWithComplexObjects
{
  public class Exercises
  {
    public string Name { get; set; }
    public int MaxWeightKg { get; set; }
    public string Area { get; set; }

    public Exercises(string name, int maxWeightKg, string area)
    {
      Name = name;
      MaxWeightKg = maxWeightKg;
      Area = area;
    }

    public Exercises() { }
  }

  internal class Program
  {
    static List<Exercises> exercises = new List<Exercises>();
    static void Main(string[] args)
    {
      // Adding new items if a constructor exists
      exercises.Add(new Exercises("Bench Press", 60, "Chest"));
      exercises.Add(new Exercises("Chest Flys", 50, "Chest"));
      exercises.Add(new Exercises("Cable Bicep Curl", 30, "Arms"));
      exercises.Add(new Exercises("Cable Hammer Curl", 60, "Arms"));
      exercises.Add(new Exercises("Hack Squat", 60, "Legs"));
      exercises.Add(new Exercises("Smith Machine Bulgarian Split Squat", 53, "Legs"));
      exercises.Add(new Exercises("Dumbbell Lateral Raise", 10, "Back"));

      // Adding new items if a constructur doesn't exist
      exercises.Add(new Exercises { Name = "Barbell Back Squat", MaxWeightKg = 100, Area = "Legs" });

      // Test adding a custom exercise
      Console.Write("Enter a name for a exercise: ");
      string exerciseName = Console.ReadLine();

      Console.Write("Enter the maximum weight used for the exercise (kg): ");
      int exerciseWeight = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the area of the body this exercise trains: ");
      string exerciseArea = Console.ReadLine();
      
      AddExercise(exerciseName, exerciseWeight, exerciseArea);

      // Print out the contents of the List
      Console.WriteLine("Exercises in Database: ");
      foreach(var exercise in exercises)
      {
        Console.WriteLine($"Name: {exercise.Name} - Max Weight (kg): {exercise.MaxWeightKg}");
      }

      // Populates this list where the exercises are focused on the Chest
      List<Exercises> chestExercises = exercises.Where(e => e.Area == "Chest").ToList();
      Console.WriteLine("Exercises that focus on the Chest: ");
      int count = 1;
      foreach(var chest in chestExercises)
      {
        Console.WriteLine($"{count}. Name: {chest.Name} - Max Weight (kg): {chest.MaxWeightKg}");
        count++;
      }
    }

    public static void AddExercise(string name, int maxWeightKg, string area)
    {
      exercises.Add(new Exercises(name, maxWeightKg, area));
    }
  }
}
