namespace XpMan.XmasTree
{
  public abstract class Elf
  {
    private readonly Santa _santa;

    protected Elf(Santa santa)
    {
      _santa = santa;
    }

    internal void TellSanta(string type, string child)
    {
      _santa.MadeAToy(Name, type, child);
    }

    internal bool OnNaughtyList(string child)
    {
      return _santa.IsOnNaughtyList(child);
    }

    public abstract Toy MakePresent(string child);
    protected abstract string Name { get; }
  }
}