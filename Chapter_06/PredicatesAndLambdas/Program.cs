namespace PredicatesAndLambdas
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // A lambda expression consists of two parts
      // 1. Parameters
      // - Written on the left-hand side of => (this symbol is referred to as "goes to" or "becomes")
      // 2. Expression or Statement Block
      // - The expression or action to perform is on the right-hand side of =>

      // This reads as:
      // "Take an input 'x' and turn it into x multiplied by x
      // x => x * x;

      List<int> numbers = new List<int>() { 7, 2, 9, 4, 1, 10, 3, 6, 8, 5};

      // The lambda here is essentially saying
      // "Find all numbers which are higher than 5 in the 'numbers' list, and store them in the new List 'aboveFive'
      // List<int> aboveFive = numbers.FindAll(x => x > 5);

      // Another way of writing the above to store the result in a variable is where 'Predicates' are used
      // This achieves the same result 
      Predicate<int> isGreaterThanFive = x => x > 5;
      List<int> aboveFive = numbers.FindAll(isGreaterThanFive);

      Console.Write("Print the list where the numbers are only higher than 5: ");
      foreach(var number in aboveFive)
      {
        Console.Write($"{number}, ");
      }

    }
  }
}
