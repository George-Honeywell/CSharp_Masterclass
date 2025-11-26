// Expression Bodied Member is a shorthand syntax in C# that allows defining simple methods, properties, or even constructors using the lambda arrow (=>)
// instead of curly braces. Useful when a method or property contains only a single expression, making the code cleaner and reducing unnecessary syntax
// Expression bodied members can be used in methods, properties, constructors, finalizers, and indexers.

// Expression Bodied Methods
// Normally, a method in C# is written like
using Microsoft.VisualBasic;
using System.Threading.Channels;

class MathOperations
{
  public int Square(int num)
  {
    return num * num;
  }

  // Since the above method only contains a single expression, it can be simplified using EBM
  // Curly braces wre replaced with the => arrow
  // No need to use the 'return' keyword as the expression is automatically returned
  public int Squared(int num) => num * num;
}

// Expression Bodied Properties
// If you have a 'readonly' property, the same shorthand applies here
class Person
{
  private string name;

  public Person(string name)
  {
    this.name = name;
  }

  public string Name
  {
    get { return name; }
  }

  // With Expression Bodied Properties
  public string Name => name;
}

// Expression Bodied Constructors
// Constructors can also use expression bodied syntax if they only contains a single statement
class Logger
{
  private string message;

  public Logger(string msg)
  {
    message = msg;
  }

  // Expression Bodied Constructors
  public Logger(string msg) => message = msg;
}

// Expression Bodied Finalizers also work for finalizers, which are used for cleanup when an object is destroyed (destructor)
class FileHandler
{
  ~FileHandler()
  {
    Console.WriteLine("Finalizer Called - Object Destroyed.");
  }

  // Expression Bodied Syntax
  ~FileHandler() => Console.WriteLine("Finalizer Called - Object Destroyed.");
}

// Expression Bodied Indexers
// Indexers allow objects to be indexed like arrays. Expression bodied members make indexers shorter when they contrain a single return statement
class Collection
{
  private int[] numbers = { 1, 2, 3, 4, 5 };

  public int this[int index]
  {
    get { return numbers[index]; } 
  }

  // Expression Bodied Syntax
  public int this[int index] => numbers[index];
}

/*
 * When to use Expression Bodied Members?
 * - When methods or properties contain only a single expression
 * - Best for Readability and conciseness
 * - Great for simple get-only properties, lightweight methods, constructors, finalizers, and indexers 
 */