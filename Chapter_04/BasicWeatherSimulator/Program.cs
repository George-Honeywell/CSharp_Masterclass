namespace BasicWeatherSimulator
{
  internal class Program
  {
    static int[] temperature;
    static string[] conditions = { "Clear", "Cloudy", /*"Overcast", "Light Rain", "Heavy Rain", "Foggy", "Snowy"*/ };
    static string[] weatherConditions;

    static void Main(string[] args)
    {
      Console.Write("Enter the number of days to simulate: ");
      int days = int.Parse(Console.ReadLine());

      temperature = new int[days];
      weatherConditions = new string[days];

      Random rand = new Random();

      for(int i = 0; i < days; i++)
      {
        temperature[i] = rand.Next(-10, 36);
        weatherConditions[i] = conditions[rand.Next(conditions.Length)];
      }

      Console.WriteLine($"The highest temperature is: {GetMaxTemperature()}");     
      Console.WriteLine($"The lowest temperature is: {GetLowestTemperature()}");
      Console.WriteLine($"The average temperature is: {GetAverageTemp()}");
      Console.WriteLine($"The most common weather condition is: {GetMostCommonWeatherCondition(weatherConditions)}");
    }

    static int GetMaxTemperature()
    {
      return temperature.Max();
    }

    static int GetLowestTemperature()
    {
      return temperature.Min(); 
    }

    static double GetAverageTemp()
    { 
      return Math.Round(temperature.Average(), 2); 
    }

    static string GetMostCommonWeatherCondition(string[] conditions)
    {
      int count = 0;
      bool tieDetected = false;
      string mostCommon = conditions[0];
      string[] processedConditions = new string[conditions.Length];

      for (int i = 0; i < conditions.Length; i++)
      {
        int tempCount = 0;

        for(int j = 0; j < conditions.Length; j++)
        {
          if (conditions[j] == conditions[i])
          {
            tempCount++;
          }
        }

        if (tempCount > count)
        {
          count = tempCount;
          mostCommon = conditions[i];
          tieDetected = false;
        }
        else if (tempCount == count)
        {
          if (conditions[i] != mostCommon)
            tieDetected = true;
        }
      }
      
      if (count == 1)
        return "No common conditions found.";
      else if (tieDetected == true)
        return "Multiple conditions!";
      else
        return mostCommon;
    }
  }
}
