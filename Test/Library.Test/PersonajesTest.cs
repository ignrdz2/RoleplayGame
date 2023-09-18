using NUnit.Framework;

namespace Program
{
  public class PersonajeTest
  {

    [Test]
    public void TestWizard()
    {
      Personaje mago = new Wizard("Axeloncio", 100, 100);
      Assert.AreEqual("Axeloncio", mago.Name);
      Assert.AreEqual("Wizard", mago.Category);
      Assert.AreEqual(100, mago.Initial_health);
      Assert.AreEqual(100, mago.Current_health);
    }

    [Test]
    public void TestEnano()
    {
      Personaje enano = new Enano("Pedrozo", 45, 60);
      Assert.AreEqual("Pedrozo", enano.Name);
      Assert.AreEqual("Enano", enano.Category);
      Assert.AreEqual(45, enano.Initial_health);
      Assert.AreEqual(60, enano.Current_health);
    }

    [Test]
    public void TestElfo()
    {
      Personaje elfo = new Elfo("Ape", 98, 90);
      Assert.AreEqual("Ape", elfo.Name);
      Assert.AreEqual("Elve", elfo.Category);
      Assert.AreEqual(98, elfo.Initial_health);
      Assert.AreEqual(90, elfo.Current_health);
    }

    [Test]
    public void TestAttack()
    {
      Personaje mago = new Wizard("Axeloncio", 100, 100);
      Personaje enano = new Enano("Pedrozo", 45, 60);
      mago.Attack(enano, 20);
      Assert.AreEqual(40, enano.Current_health);
    }

    [Test]
    public void TestHeal()
    {
      Personaje mago = new Wizard("Axeloncio", 100, 60);
      mago.Heal(mago);
      Assert.AreEqual(100, mago.Current_health);
    }

  }

}