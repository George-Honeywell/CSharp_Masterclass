int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

int sumRowOne = 0;
int sumRowTwo = 0;
int sumRowThree = 0;

for(int i = 0; i < numbers.GetLength(0); i++)
{
  sumRowOne += numbers[0, i];
  sumRowTwo += numbers[1, i];
  sumRowThree += numbers[2, i];
}

Console.WriteLine($"The Sum of Row 1 is {sumRowOne}.");
Console.WriteLine($"The Sum of Row 2 is {sumRowTwo}.");
Console.WriteLine($"The Sum of Row 3 is {sumRowThree}.");