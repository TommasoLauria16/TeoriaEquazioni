using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;
namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEquazionePrimoGradoDeterminata()
        {
            double a = 6;
            bool valoreAspettato = true;
            bool ValoreRitorno = Equazioni.IsDeterminated(a);
            Assert.AreEqual(valoreAspettato, ValoreRitorno);
        }
    }
}
