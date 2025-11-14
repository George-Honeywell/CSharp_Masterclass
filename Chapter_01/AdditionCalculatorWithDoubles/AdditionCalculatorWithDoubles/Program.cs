Console.WriteLine("Welcome to the Addition Calculator!");
Console.WriteLine("Enter the first number: ");
bool firstNumber = double.TryParse(Console.ReadLine(), out double firstNum);
if(!firstNumber)
{
  Console.WriteLine("The number entered was not in the correct format!");
  return;
}

Console.WriteLine("Enter the second number: ");
bool secondNumber = double.TryParse(Console.ReadLine(), out double secondNum);
if(!secondNumber)
{
  Console.WriteLine("The number entered was not in the correct format!");
  return;
}

double sum = firstNum + secondNum;
Console.WriteLine($"{firstNum} + {secondNum} = {Math.Round(sum, 2)}");

// Using 'Math.Round()' keeps the output of the calculation to 2 decimal places
// Without rounding, 15.3 + 13.9 would equal 29.2000000003 (or thereabouts)
// Doing the same calculation using 'Math.Round()', the sum is 29.2.
// 'Math.Round(sum, 2)', the 2 rounds the answer to 2 decimal places