using System.Linq;

namespace XpMan.XmasTree
{
  public class GreenWoodenToyMakingElf : WoodenToyMakingElf
  {
    private string _colour;

    public GreenWoodenToyMakingElf(Santa santa) : base(santa)
    {
      _colour = "green";
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

    protected override string Name
    {
      get { return "Green Wooden Toy Making Elf"; }
    }
  }
}