namespace XpMan.XmasTree
{
  public class ToyMakingElf : Elf
  {
    public ToyMakingElf(Santa santa)
      : base(santa)
    {
    }

    public override Toy MakePresent(string child)
    {
      if (!base.OnNaughtyList(child))
      {
        var toyType = "Train";
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
      get { return "Toy Making Elf"; }
    }
  }
}