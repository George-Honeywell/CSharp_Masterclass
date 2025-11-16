// Declaring variables to use later on
string questionOneAnswer    = "";
string questionTwoAnswer    = "";
string questionThreeAnswer  = "";
string questionFourAnswer   = "";
string questionFiveAnswer   = "";
int playerScore = 0;
double correctPercentage = 0.0;

Console.WriteLine("Welcome to the Basic Quiz!");
Console.WriteLine("You will be given 5 questions of which you need to get as many correct answers as possible.");
Console.WriteLine("You can gain a maximum of 5 points!");
Console.WriteLine("You only get ONE guess per question, though!");

Console.WriteLine("Question 1 - What is the capital of the United Kingdom?");
questionOneAnswer = Console.ReadLine().ToLower().Trim();
if (questionOneAnswer == "london")
{
  Console.WriteLine("Correct!");
  playerScore++;
}
else
  Console.WriteLine("Incorrect!");
// =============================================================
Console.WriteLine("Question 2 - What is the square root of 64?");
questionTwoAnswer = Console.ReadLine().Trim();
if (questionTwoAnswer == "8")
{
  Console.WriteLine("Correct!");
  playerScore++;
}
else
  Console.WriteLine("Incorrect!");
// =============================================================
Console.WriteLine("Question 3 - How many seconds are there in 1 hour?");
questionThreeAnswer = Console.ReadLine().Trim();
if (questionThreeAnswer == "3600")
{
  Console.WriteLine("Correct!");
  playerScore++;
}
else
  Console.WriteLine("Incorrect!");
// =============================================================
Console.WriteLine("Question 4 - What colour do you get if you mix Blue and Yellow?");
questionFourAnswer = Console.ReadLine().ToLower().Trim();
if (questionFourAnswer == "green")
{
  Console.WriteLine("Correct!");
  playerScore++;
}
else
  Console.WriteLine("Incorrect!");
// =============================================================
Console.WriteLine("Question 5 - In meters, how tall is the Effiel Tower?");
questionFiveAnswer = Console.ReadLine().Trim();
if (questionFiveAnswer == "330")
{
  Console.WriteLine("Correct!");
  playerScore++;
}
else
  Console.WriteLine("Incorrect!");

correctPercentage = Math.Round((playerScore / 5f) * 100f, 0);
Console.WriteLine("You finished the quiz!");
Console.WriteLine("Your score can be seen below.");
Console.WriteLine($"You scored {playerScore} out of 5, answering {correctPercentage}% questions correctly!");