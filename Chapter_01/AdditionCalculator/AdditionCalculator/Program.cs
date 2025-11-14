Console.WriteLine("Welcome to the Addition Calculator!");
Console.WriteLine("Enter your first whole number: ");
bool firstNumber = int.TryParse(Console.ReadLine(), out int firstNum);
if (!firstNumber)
{
  Console.WriteLine("The number you entered was not in the correct format!");
  return;
}

Console.WriteLine("Enter your second whole number: ");
bool secondNumber = int.TryParse(Console.ReadLine(), out int secondNum);
if (!secondNumber)
{
  Console.WriteLine("The number you entered was not in the correct format!");
  return;
}

int sum = firstNum + secondNum;

Console.WriteLine($"{firstNum} + {secondNum} = {sum}");

// Using 'TryParse' to avoid the application crashing if an incorrect data type is entered just by using 'Parse'
// 'System.FormatException' is thrown by using 'Parse' if anything other than a whole number is entered