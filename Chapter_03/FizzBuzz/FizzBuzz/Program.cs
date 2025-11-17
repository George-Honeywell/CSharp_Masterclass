Console.WriteLine("The 'Fizz Buzz' Problem.");
Console.WriteLine("The application will count from 1 to 100.");
Console.WriteLine("If the number is a multiple of 3, it will print out 'Buzz'.");
Console.WriteLine("if the number is a multiple of 5, it will print out 'Fizz'.");
Console.WriteLine("If the number if a multiple of both 3 and 5, print out 'Fizz Buzz!'");

for(int i = 1; i <= 100; i++)
{
  if(i % 5 == 0 && i % 3 == 0)
    Console.WriteLine($"[{i}] Fizz Buzz!");
  else if(i % 5 == 0)
    Console.WriteLine($"[{i}] Buzz.");
  else if(i % 3 == 0)
    Console.WriteLine($"[{i}] Fizz.");
  else
    Console.WriteLine($"[{i}]");
}
