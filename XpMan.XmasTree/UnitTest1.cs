using System.Security.AccessControl;
using NUnit.Framework;

namespace XpMan.XmasTree
{
  [TestFixture]
  public class UnitTest1
  {
    [Test]
    public void TestMethod1()
    {
      var santa = new Santa();
      var elf = new ToyMakingElf(santa);
      var toy = elf.MakePresent("Sarah");
      Assert.That(toy.Type, Is.EqualTo("Train"));
    }


    [Test]
    public void TestMethod2()
    {
      var santa = new Santa();
      var elf = new WoodenToyMakingElf(santa);
      var toy = elf.MakePresent("John");
      Assert.That(toy.Type, Is.EqualTo("Wooden toy"));
    }

    [Test]
    public void TestMethod3()
    {
      var santa = new Santa();
      var elf = new GreenWoodenToyMakingElf(santa);
      var toy = elf.MakePresent("Susan");
      Assert.That(toy.Type, Is.EqualTo("Green wooden toy"));
    }

    [Test]
    public void TestMethod4()
    {
      var santa = new Santa();
      var elf = new GreenWoodenToyMakingElf(santa);
      var toy = elf.MakePresent("Bad Tom");
      Assert.That(toy.Type, Is.EqualTo("Coal"));
      Assert.That(toy.Reason, Is.EqualTo("Bad Tom was on the naughty list"));
    }

    [Test]
    public void AllSantasPresents()
    {

      var santa = new Santa();
      var allPresents = santa.GetPresents();
      Assert.That(allPresents["Susan"].Type, Is.EqualTo("Green wooden toy"));
      Assert.That(allPresents["John"].Type, Is.EqualTo("Wooden toy"));
      Assert.That(allPresents["Good Tom"].Type, Is.EqualTo("Red wooden toy"));
      Assert.That(allPresents["Bad Tom"].Type, Is.EqualTo("Coal"));
      Assert.That(allPresents["Bad Tom"].Reason, Is.EqualTo("Bad Tom was on the naughty list"));
      Assert.That(allPresents["Sarah"].Type, Is.EqualTo("Train"));
    }
  }
}
