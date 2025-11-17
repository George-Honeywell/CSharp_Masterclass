Console.WriteLine("Welcome to guess the number!");
Console.WriteLine("The rules are straight forward, guess the number!");
Console.WriteLine("The number will be between 1 and 100. Good luck!");
Console.Write("Enter your number: ");

// Create an instance of the 'Random' class
Random rand = new Random();

// The 'maxValue' isn't returned, so setting the maxValue to 101 ensures the random generation is between 1 and 100
int randomNumber = rand.Next(1, 101);
string guess = Console.ReadLine();

bool isValidNumber = int.TryParse(guess, out int res);
if(isValidNumber)
{
  if (res == randomNumber)
    Console.WriteLine("You guessed correctly!");
  else
  {
    Console.WriteLine("Incorrect guess!");
    Console.WriteLine($"The correct number was {randomNumber}");
  }
}
else
  Console.WriteLine("Invalid Input - Quitting...");
