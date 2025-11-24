using System.Security.Cryptography.X509Certificates;

namespace IntroductionIntoClasses
{

  // 'internal class' means that it can only be accessed from within the same assembly
  internal class Car
  {
    // Member Variables
    private string _manufacturer { get; set; }
    private bool _isElectric { get; set; }
    private string _model = "";


    // Properties (Encapsulation)
    public string Model {
      get
      {
        if (_isElectric)
          return _model + " Electric";
        else
          return _model;
      } 
      set 
      {
        if (string.IsNullOrEmpty(_model))
        {
          Console.WriteLine("No model was set!");
          _model = "<None>";
        }
        else
          _model = value;
      } 
    }

    // Constructor - The same name of the class
    // Constructors are called whenever a new instance of a class is created. Typically doesn't return a value
    public Car(string manufacturer, string model, bool isElectric) 
    {
      _manufacturer = manufacturer;
      Model = model;
      _isElectric = isElectric;
      Console.WriteLine($"A Car object has been created. Manufacturer: {manufacturer}. Model: {model}. Is the car electric: {IsCarElectric(isElectric)}");
    }

    private static string IsCarElectric(bool isElectric)
    {
      if (isElectric)
        return "Yes";
      else
        return "No";
    }
  }
}
