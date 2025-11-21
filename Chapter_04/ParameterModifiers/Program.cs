// In C#, there are parameter modifiers which change how arguments are passed to methods
// These are 'ref', 'out', and 'in'
// When a value is passed to a method, it is typically passed by value, which means the method works with a copy of the data
// Sometimes, we want to pass a reference to the original data or control how the data is passed, this is where parameter modifiers come in
// 1. Pass by Value - Imagine giving someone a copy of your notes. If they write on the copy, the original notes are left untouched
// 2. Pass by Reference - The original data is changed
// 3. 'out' - Giving someone a blank sheet of paper, they write on it and give it back
// 4. 'in' - Giving someone your notes, but they can only read and not make any changes


/// <summary>
/// 
/// 'ref' Modifier
/// Allows us to pass a variable by reference, rather than by value.
/// As an example, the method below takes in an integer, adds 10 to it, then returns the result. We'd expect to see 'myNumber' return 15
/// However, myNumber returns 5. This is because the value was only passed by value, leaving the original data untouched.
/// Once the function is finished, the changed value is lost
/// 
/// </summary>
void PassByValue(int number)
{
  number += 10;
}

int passByValue = 5;
PassByValue(passByValue);
Console.WriteLine(passByValue);

/// <summary >
/// 
/// If we take the method from above, and use the 'ref' keyword, 15 will be returned as expected.
/// Key Points about using 'ref'
/// - The variable must be initialized before passing it to a method
/// - Any modifications inside the method affect the original value
/// - Useful when we want a method to modify existing data
/// 
/// </summary>
void PassByRef(ref int number)
{
  number += 10;
}

int passByRef = 5;
PassByRef(ref passByRef);
Console.WriteLine(passByRef);


/// <summary>
/// 
/// The below method returns the new value of 15 without using 'ref'
/// 
/// </summary>
int ReturnVal(int number)
{
  return number += 10;
}

int returnVal = ReturnVal(5);
Console.WriteLine(returnVal);


/// <summary>
///
/// 'out' Modifier
/// The 'out' modifier is similar to 'ref' but with the key difference of, the method must assign a value to the out parameter before returning
/// - The variable does not need to be initialized before passing it
/// - The method must assign a value before returning
/// - Useful when a method needs to return multiple values
/// </summary>
void GetValue(out int result)
{
  // 'result' must be assigned a value before exiting the method
  // Not assigning a value to the out variable will result in a compile error
  result = 10;
}

int myVal = 5;
GetValue(out myVal);
Console.WriteLine(myVal); // Returns '10'. The original value is overwritten

// Example of returning multiple values
void Calculate(int x, int y, out int sum, out int product)
{
  sum = x + y;
  product = x * y;
}

int a = 5;
int b = 3;
int sum;
int product;
Calculate(a, b, out sum, out product);
Console.WriteLine($"Sum is: {sum}. Product is: {product}.");

/// <summary>
/// 
/// 'in' Modifier
/// The 'in' modifier allows us to pass a variable by reference, but it cannot be modified inside the method
/// Useful when passing large objects to a method efficiently without allowing them to be changed
/// - The variable must be initialized before passing it
/// - The method cannot modifiy the parameter
/// - Useful for performance optimization when working with large objects
/// 
/// </summary>
void PrintValue(in int number)
{
  Console.WriteLine(number); // Allowed
  // number += 10; // Not allowed - will cause a compile error!
}

int num = 5;
PrintValue(num);