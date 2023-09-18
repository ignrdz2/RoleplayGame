using NUnit.Framework;

namespace Program
{
  public class MagicTest
  {

    [Test]
    public void TestWizard()
    {
      Wizard mago = new Wizard("Axel", 100, 100);
      SpellBook grimorio = new SpellBook();
      mago.SpecificItems[typeof(SpellBook)] = grimorio;

      Enano victima = new Enano("Victima", 100, 100);

      Spell hechizo = new Spell("Llamarada", 20, 5, "Fuego");
      grimorio.AddSpell(hechizo);

      mago.UseSpell(hechizo, victima, grimorio);

      Assert.AreEqual(80, victima.Current_health);
    }
  }
}