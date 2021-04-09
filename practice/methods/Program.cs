using System;

namespace methods
{
  class Program
  {
    static void Main(string[] args)
    {
      // var number = int.Parse("abc");
      int number;
      var result = int.TryParse("abc", out number);
      if (result)
        Console.WriteLine(number);
      else
        Console.WriteLine("Conversion failed.");
    }

    static void UseParams()
    {
      var calculator = new Calculator();
      Console.WriteLine(calculator.Add(3, 2));
      Console.WriteLine(calculator.Add(3, 2, 4, 6, 7));
    }

    static void UsePoints()
    {
      try
      {
        var point = new Point(10, 20);
        point.Move(null);
        Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

        point.Move(100, 200);
        Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
      }
      catch (Exception)
      {
        System.Console.WriteLine("An unexpected error occurred!");
      }
    }
  }
}
