using System;
using System.Collections.Generic;

namespace XpMan.XmasTree
{
  public class Santa
  {
    private static readonly IDictionary<string, bool> NaughtList = new Dictionary<string, bool>
    {
      {"Bad Tom", true},
      {"Susan", false},
      {"John", false},
      {"Sarah", false},
      {"Good Tom", false}
    };

    public void MadeAToy(string name, string type, string child)
    {
      Console.WriteLine("A {0} toy has been made for {1} by {2}", type, child, name);
    }

    public bool IsOnNaughtyList(string child)
    {
      return NaughtList[child];
    }

    public IDictionary<string, Toy> GetPresents()
    {
      return new Dictionary<string, Toy>
      {
        {"Susan", new GreenWoodenToyMakingElf(this).MakePresent("Susan")},
        {"Bad Tom", new GreenWoodenToyMakingElf(this).MakePresent("Bad Tom")},
        {"John", new WoodenToyMakingElf(this).MakePresent("John")},
        {"Sarah", new ToyMakingElf(this).MakePresent("Sarah")},
        {"Andy", new PlasticToyMakingElf(this).MakePresent("Sarah")},
        {"Good Tom", new RedWoodenToyMakingElf(this).MakePresent("Good Tom")},
      };
    }
  }
}