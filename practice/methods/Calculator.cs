namespace methods
{
  public class Calculator
  {
    public int Add(params int[] numbers)
    {
      var sum = 0;
      foreach (char number in numbers)
      {
        sum += number;
      }

      return sum;
    }
  }
}
