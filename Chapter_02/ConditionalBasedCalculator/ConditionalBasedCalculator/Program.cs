Console.Write("What operation would you like to perform on 2 numbers? (+, -, *, /): ");
string op = Console.ReadLine();

double firstNum = 0;
double secondNum = 0;
double result = 0;
bool isValid = false;

switch(op)
{
  case "+":
    Console.WriteLine("You've chosen to add 2 numbers.");
    
    Console.Write("Enter your first number: ");
    isValid = double.TryParse(Console.ReadLine(), out firstNum);
    if (!isValid)
    {
      Console.WriteLine("Incorrect Value.");
      return;
    }

    Console.Write("\nEnter your second number: ");
    isValid = double.TryParse(Console.ReadLine(), out secondNum);
    if (!isValid)
    {
      Console.WriteLine("Incorrect Value.");
      return;
    }
    result = firstNum + secondNum;
    Console.WriteLine($"{firstNum} + {secondNum} = {result}");
    break;

  case "-":
    Console.WriteLine("You've chosen to subtract 2 numbers.");

    Console.Write("Enter your first number: ");
    isValid = double.TryParse(Console.ReadLine(), out firstNum);
    if (!isValid)
    {
      Console.WriteLine("Incorrect Value.");
      return;
    }

    Console.Write("\nEnter your second number: ");
    isValid = double.TryParse(Console.ReadLine(), out secondNum);
    if (!isValid)
    {
      Console.WriteLine("Incorrect Value.");
      return;
    }
    result = firstNum - secondNum;
    Console.WriteLine($"{firstNum} - {secondNum} = {result}");
    break;

  case "*":
    Console.WriteLine("You've chosen to multiply 2 numbers.");

    Console.Write("Enter your first number: ");
    isValid = double.TryParse(Console.ReadLine(), out firstNum);
    if (!isValid)
    {
      Console.WriteLine("Incorrect Value.");
      return;
    }

    Console.Write("\nEnter your second number: ");
    isValid = double.TryParse(Console.ReadLine(), out secondNum);
    if (!isValid)
    {
      Console.WriteLine("Incorrect Value.");
      return;
    }
    result = firstNum * secondNum;
    Console.WriteLine($"{firstNum} * {secondNum} = {result}");
    break;

  case "/":
    Console.WriteLine("You've chosen to divide 2 numbers.");

    Console.Write("Enter your first number: ");
    isValid = double.TryParse(Console.ReadLine(), out firstNum);
    if (!isValid)
    {
      Console.WriteLine("Incorrect Value.");
      return;
    }

    Console.Write("\nEnter your second number: ");
    isValid = double.TryParse(Console.ReadLine(), out secondNum);
    if (!isValid)
    {
      Console.WriteLine("Incorrect Value.");
      return;
    }

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