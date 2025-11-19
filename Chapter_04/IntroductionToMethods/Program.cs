// Declare Variables 
int numberOne = 5;
int numberTwo = 5;

// Create a method which will return an 'int' and pass in 2 parameters
// Methods can also use 'void', which tells the compiler that the method isn't expecting to return a value
// Methods can have a few keywords before the type being returned, but this will be covered later.
// public, private, etc.
int Add(int num1, int num2)
{
  // The below code will work by storing the sum of num1 and num2 in 'result', then using 'return' to return the sum
  // int result = num1 + num2;
  // return result;

  // Or to make it easier, just simply return the result
  return num1 + num2;
}

// As the method returns a value, the value can be stored in a variable to be used elsewhere.
// When passing variables into a function, they are commonly known as 'arguments'
int result = Add(numberOne, numberTwo);
Console.WriteLine(result);

// Actual values can be passes into the methods arguments too, not just variables
int result1 = Add(25, 25);
Console.WriteLine(result1);

// Other data types can be passed into methods too
// Parameters can also be different data types
// As described above, methods can have the 'void' so the compiler doesn't expect a return value
DateTime now = DateTime.Now;
void GreetUser(string firstName, string lastName, DateTime lastLogin)
{
  Console.WriteLine($"Welcome, {firstName} {lastName}! You last logged in at: {lastLogin}");
}

GreetUser("George", "Honeywell", now);