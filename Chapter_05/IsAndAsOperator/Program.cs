// In C#, there are the 'is' and 'as' operator which are used for type-checking and type-conversion
// - The 'is' operator checks if an object is of a specific type and returns a bool
// - The 'as' operator attempts to convert an object to a specified type and returns 'null' if the conversion isn't possible, instead of throwing an exception

// --- The 'is' Operator
// Used to check if an object is of a certain type
// If both objects are the same type, returns true, if not, return false

class Animal { }
class Dog : Animal { }

Animal myPet = new Dog();

if(myPet is Dog)
  Console.WriteLine("'myPet' is of type 'Dog'.");
else
  Console.WriteLine("'myPet' is not of type 'Dog'.");

// With C# 7 and later, 'is' can be used with pattern matching
object obj = "Hello, World!";
if(obj is string message)
  Console.WriteLine($"The message is: {message}");
// Eliminates the need for explicit casting

// --- The 'as' operator
// Used for safe type conversion. Instead of throwing an exception if the conversion fails, it returns null instead

class Animal2 { }
class Dog2 : Animal2 { }
class Cat : Animal2 { }

Animal2 myNewPet = new Dog2();
Dog2 myDog = myNewPet as Dog2;
if (myDog != null)
  Console.WriteLine("Successfully cast to a 'Dog'");
else
  Console.WriteLine("Conversion Failed.");

// However, if 'myPet' was a 'Cat'
Animal2 myCat = new Cat();
Dog2 myDog2 = myCat as Dog2;
// -- Conversion failed
