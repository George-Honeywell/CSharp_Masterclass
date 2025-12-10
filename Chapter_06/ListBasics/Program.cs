namespace ListBasics
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Declaring a new list and initializing it
      List<string> names = new List<string>();
      List<string> distinctNames = new List<string>();

      // Add items to the list
      names.Add("George");
      names.Add("Andy");
      names.Add("Nick");
      names.Add("Steph");
      names.Add("Frank");
      names.Add("George");

      // Loop through the entire list and print out the names
      Console.WriteLine("The list contains the following names: ");
      foreach(var name in names)
      {
        Console.WriteLine($"- {name}");
      }

      // Removing items from a List
      // Only removed the first occurrence of the object from a list
      // The second 'George' added will remain in the list, only the first 'George' object is removed
      names.Remove("George");
      Console.WriteLine("The list contains the following names: ");
      
      // Looping through the list again, the name 'George' won't appear as it's been removed
      foreach (var name in names)
      {
        Console.WriteLine($"- {name}");
      }

      // Creating a new list to remove any duplicates
      foreach(var name in names)
      {
        if (!distinctNames.Contains(name))
          distinctNames.Add(name);
      }

      Console.WriteLine("The distinctNames list contains: ");
      foreach(var name in distinctNames)
      {
        Console.WriteLine($"- {name}");
      }

      // Another approach is using the 'Remove()' method
      // Removing all 'George' objects from the list
      Console.WriteLine("Removing all 'George' objects from the list.");
      bool hasRemovedObjects = names.Remove("George");
      while (hasRemovedObjects)
      {
        hasRemovedObjects = names.Remove("George");
      }

      foreach(var name in names)
      {
        Console.WriteLine($"- {name}");
      }

      // Initializing lists can be simplified too
      // 'Collection Expression' introduced in C# 12
      // Avoids calling the constructor
      // Compiler translates this into what is shown for the 'surname' below
      List<string> newNames =
        [
          "George",
          "Andy",
          "Nick",
          "Steph",
          "Frank"
        ];

      // Traditional collection initializer, available since C# 3
      // Works in all supported versions of C# and the most used
      List<string> surnames = new List<string>
      {
        "Honeywell",
        "Tomline"
      };

      // -- Sorting a list
      // Can be used on Strings, Chars, and other data types too
      List<int> numbers = new List<int>() { 1, 6, 2, 3, 6, 9, 4, 1, 3, 6, 2, 1, 4, 7, 8 };

      Console.Write("'numbers' list before sorting: ");
      foreach(var number in numbers)
        Console.Write($"{number}, ");

      // Sorts the List into ascending order
      Console.Write("\n'numbers' list after sorting: ");
      numbers.Sort();
      foreach(var number in numbers)
        Console.Write($"{number}, ");

      // -- 'FindAll()' Method
      List<int> numbersTwo = new List<int>() { 47, 3, 89, 22, 61, 14, 76, 95, 8, 33 };
      List<int> highNumbers = numbersTwo.FindAll(x => x >= 30);
      Console.Write("\nDisplay numbers 30 or above: ");
      foreach(var highNumber in highNumbers)
        Console.Write($"{highNumber}, ");
    }
  }
}
