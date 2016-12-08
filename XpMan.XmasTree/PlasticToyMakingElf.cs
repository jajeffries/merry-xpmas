namespace XpMan.XmasTree
{
  public class PlasticToyMakingElf : Elf
  {
    public PlasticToyMakingElf(Santa santa) : base(santa)
    {
    }

    public override Toy MakePresent(string child)
    {
      if (!base.OnNaughtyList(child))
      {
        var toyType = "Plastic Spaceship";
        this.TellSanta(toyType, child);
        return new Toy(toyType);
      }
      else
      {
        return new NaughtyChildToy(child);
      }
    }

    protected override string Name { get { return "Plastic Toy Making Elf"; } }
  }
}