
using System;

namespace XpMan.XmasTree
{
  public class Program
  {
    public static void Main()
    {
      var santa = new Santa();
      var presents = santa.GetPresents();

      foreach (var present in presents)
      {
        Console.WriteLine("Santa's got " + present.Key + " a " + present.Value.Type);
      }
      Console.ReadLine();
    }
  }
}
