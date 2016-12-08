namespace XpMan.XmasTree
{
  public class Toy
  {
    public string Reason { get; set; }
    public string Type { get; set; }

    public Toy(string train, string reason = null)
    {
      Reason = reason;
      Type = train;
    }
  }
}