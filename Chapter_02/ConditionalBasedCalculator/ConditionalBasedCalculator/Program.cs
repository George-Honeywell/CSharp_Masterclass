double firstNum = 0;
double secondNum = 0;
double result = 0;
bool isValid = false;

Console.Write("Enter your first number: ");
isValid = double.TryParse(Console.ReadLine(), out firstNum);
if (!isValid)
{
  Console.WriteLine("Incorrect Value.");
  return;
}

Console.Write("Enter your second number: ");
isValid = double.TryParse(Console.ReadLine(), out secondNum);
if (!isValid)
{
  Console.WriteLine("Incorrect Value.");
  return;
}

Console.Write("What operation would you like to perform on the 2 numbers? (+, -, *, /): ");
string op = Console.ReadLine();

switch(op)
{
  case "+":   
    result = firstNum + secondNum;
    Console.WriteLine($"{firstNum} + {secondNum} = {result}");
    break;

  case "-":
    result = firstNum - secondNum;
    Console.WriteLine($"{firstNum} - {secondNum} = {result}");
    break;

  case "*":
    result = firstNum * secondNum;
    Console.WriteLine($"{firstNum} * {secondNum} = {result}");
    break;

  case "/":
    if(secondNum == 0)
    {
      Console.WriteLine("Unable to divide by zero!");
      return;
    }

    result = firstNum / secondNum;
    Console.WriteLine($"{firstNum} / {secondNum} = {result}");
    break;

  default:
    Console.WriteLine("Invalid Operator chosen!");
    break;
}