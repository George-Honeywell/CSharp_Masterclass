using InnerClasses;

namespace InnerClasses
{
  // An Inner Class (also known as a 'nested class') is a class that is declared inside another class
  // This means that an inner class exists within the scope of an outer class
  // Useful when a class is only relevant within the context of another class

  // Inner classes can be beneficial in specific scenarios;
  // - Encapsulation: Inner classes help group related logic together, improving readability and maintainability
  // - Restricting Scope: if a class is only meant to be used inside another class, it makes sense to keep it enclosed
  // - Better Organization: when a class is tightly coupled to another class, defining it as an inner class can improve code structure

  // Best Practices
  // - Use innder classes only when they are strongly related to the outer class
  // - Keep inner classes private, unless external access is necessary
  // - Use static inner classes if they don't require an outer instance
  // - Ensure clean separation of responsibilities

  internal class OuterClass
  {
    private string outerField = "From OuterClass";

    public class InnerClass
    {
      // This class does not have access to 'OuterClass's members
      public void DisplayMessage()
      {
        Console.WriteLine("From InnerClass");
      }
    }
  }
}

class BasicSyntax
{
  static void Main()
  {
    OuterClass.InnerClass innerObj = new OuterClass.InnerClass();
    innerObj.DisplayMessage();

    // An inner class can access members of the outer class if they are marked as public or protected
    // Or if it has a reference to the outer class.
    OuterClassTwo outerObj = new OuterClassTwo();
    OuterClassTwo.InnerClassTwo innerObjTwo = new OuterClassTwo.InnerClassTwo(outerObj);
    innerObjTwo.DisplayOuterField();


  }
}
