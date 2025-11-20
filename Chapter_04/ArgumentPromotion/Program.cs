/*
  Argument Promotion is when the compiler 'Implicitly' converts a variable from one type to another
  This means that is a method has a double as a parameter, an 'int' (or any smaller data type) can be used
  However, this doesn't work the opposite way around. If the parameter was of type int, a double couldn't be 
  passed in, as doubles hold more memory than int.
*/

// Basic example of Argument Promotion
// Method has a 'double' parameter, then later an int is passed as an argument
// 'myInt' is then implicitly promoted from int to double
void DisplayNumber(double num)
{
  Console.WriteLine($"The number is: {num}");
}

int myInt = 43;
DisplayNumber(myInt);


// Below shows an example of a method with a larger datatype
// The expected out put is 78.53981633974483
// The reason why the the output has a decimal, is because the int was promoted to a double
void CalculateArea(double radius)
{
  double area = Math.PI * radius * radius;
  Console.WriteLine($"The area is: {area}.");
}

int myRadius = 5;
CalculateArea(myRadius);

// Method Overloading is a term used that allows functions of the same name to be used, but take in different parameters
// PLEASE NOTE: The code below will fail to compile due to the methods not being in a class (covered later)
void PrintValue(int val)
{
  Console.WriteLine($"Integer: {val}");
}

//void PrintValue(double val)
//{
//  Console.WriteLine($"Double: {val}");
//}

// Using the two methods above, simply passing in an int or double, the compiler will automatically call the correct method.
PrintValue(5);
//PrintValue(5.5);

// When using explicit casting, the data type is being forced to change, which could lead to data loss
double x = 10;
int y = (int)x; // Explictly casting a double to an int - can result in data loss!

