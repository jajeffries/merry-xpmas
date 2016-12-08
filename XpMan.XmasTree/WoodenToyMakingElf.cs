namespace XpMan.XmasTree
{
  public class WoodenToyMakingElf : Elf
  {
    public WoodenToyMakingElf(Santa santa)
      :base(santa)
    {
    }

    public override Toy MakePresent(string child)
    {
      if (!base.OnNaughtyList(child))
      {
        var toyType = "Wooden toy";
        this.TellSanta(toyType, child);
        return new Toy(toyType);
      }
      else
      {
        return new NaughtyChildToy(child);
      }
    }

    protected override string Name
    {
      get { return "Wooden Toy Making Elf"; }
    }
  }
}