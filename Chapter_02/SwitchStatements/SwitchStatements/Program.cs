int day = 3;

switch(day)
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  default:
    // Default case is used whenever any of the cases are not executed.
    Console.WriteLine("It's the weekend!");
    break;
}