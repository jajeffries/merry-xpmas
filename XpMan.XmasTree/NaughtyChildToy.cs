namespace XpMan.XmasTree
{
  public class NaughtyChildToy : Toy
  {
    public NaughtyChildToy(string child) : base(null)
    {
      Reason = child + " was on the naughty list";
      Type = "Coal";
    }
  }
}