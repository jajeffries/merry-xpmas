using System.Linq;

namespace XpMan.XmasTree
{
  public class RedWoodenToyMakingElf : WoodenToyMakingElf
  {
    private string _colour;

    public RedWoodenToyMakingElf(Santa santa) : base(santa)
    {
      _colour = "Red";
    }

    public override Toy MakePresent(string child)
    {
      var toy = base.MakePresent(child);
      if (!base.OnNaughtyList(child))
      {
        toy.Type = _colour + " " + toy.Type.ToLower();
        if (toy.Type.First() == 'g')
        {
          toy.Type = toy.Type.First().ToString().ToUpper() + string.Join("", toy.Type.ToLower().Skip(1));
        }
      }
      else
      {
        return new NaughtyChildToy(child);
      }
      return toy;
    }
  }
}