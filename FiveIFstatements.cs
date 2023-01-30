using System;

namespace FiveIFstatements
{
  class Program
  {
    static void Main(string[] args)
    {
      int time = 104;
      string weather = "Clear";
      bool isStopLightRed = true;
      float gpa = 3.25f;
      double temperature = 101.45d;

      // Check Time
      if (time >= 200)
      {
          Console.WriteLine("Rise and Shine!");
      }
      else
      {
          Console.WriteLine("It is too early. Go back to bed!");
      }
      // Check Weather
      if (weather == "Cloudy")
      {
          Console.WriteLine("It is cloudy outside");
      }
      else if (weather == "Raining")
      {
          Console.WriteLine("It is raining outside!");
      }
      else if (weather == "Clear")
      {
          Console.WriteLine("It is a beautiful day outside!");
      }
      else if (weather == "ThunderLightning")
      {
          Console.WriteLine("There is thunder and lightning outside, stay indoors!!!");
      }
      else if (weather == "Snowing")
      {
          Console.WriteLine("It is snowing outside, bundle up it is cold!");
      }
      else
      {
          Console.WriteLine("Do what you want! Its a day!");
      }
      // Check Stop Light
      if (true)
      {
          Console.WriteLine("Wait until the light turns green!");
      }
      else
      {
          Console.WriteLine("You may proceed to cross the intersection");
      }
      // Check GPA
      if (gpa >= 3)
      {
          Console.WriteLine("Great job! You are passing!");
      }
      else
      {
          Console.WriteLine("Please look into improving your work");
      }
      // Check Temperature
      if (temperature < 40)
      {
          Console.WriteLine("It is cold outside, be sure to bundle up warm.");
      }
      else if (temperature <= 80)
      {
          Console.WriteLine("It is a pleasant temerature outside");
      }
      else
      {
          Console.WriteLine("It is hot outside, be careful not to get heatstroke!");
      }
    }
  }
}
