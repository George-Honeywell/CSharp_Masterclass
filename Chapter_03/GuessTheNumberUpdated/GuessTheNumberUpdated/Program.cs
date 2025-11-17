Console.WriteLine("Welcome to guess the number!");
Console.WriteLine("The rules are straight forward, guess the number!");
Console.WriteLine("The number will be between 1 and 100. Good luck!");

Random rand = new Random();

int randomNumber = rand.Next(1, 101);
int res = 0;
int numOfGuesses = 0;

while (res != randomNumber)
{
  Console.Write("Enter your number: ");
  string guess = Console.ReadLine();
  bool isValidNumber = int.TryParse(guess, out res);

  if (!isValidNumber)
  {
    Console.WriteLine("Invalid Number...");
    continue;
  }

  if (res != randomNumber)
  {
    Console.WriteLine("Incorrect guess, try again!");
    numOfGuesses++;
  }
  
  if (res < randomNumber)
    Console.WriteLine("The number I have in mind is higher!");
  else if (res > randomNumber)
    Console.WriteLine("The number I have in mind is lower!");
}

Console.WriteLine($"You guessed correctly! It took you {numOfGuesses} guesses!");