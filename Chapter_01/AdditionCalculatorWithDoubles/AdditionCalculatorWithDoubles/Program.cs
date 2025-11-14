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
Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
