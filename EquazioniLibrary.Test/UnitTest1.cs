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
        [TestMethod]
        public void TestEquazionePrimoGradoDeterminata1()
        {
            double a = 0;
            bool valoreAspettato = false;
            bool ValoreRitorno = Equazioni.IsDeterminated(a);
            Assert.AreEqual(valoreAspettato, ValoreRitorno);
        }
        [TestMethod]
        public void TestEquazioneDiPrimoGradoImpossibile()
        {
            double a = 6, b = 4;
            bool valoreAspettato = true;
            bool ValoreRitorno = Equazioni.isIncosisted(a, b);
            Assert.AreEqual(valoreAspettato, ValoreRitorno);

        }
        [TestMethod]
        public void TestEquazioneDiPrimoGradoImpossibile1()
        {
            double a = 0, b = 4;
            bool valoreAspettato = false;
            bool ValoreRitorno = Equazioni.isIncosisted(a, b);
            Assert.AreEqual(valoreAspettato, ValoreRitorno);

        }
        [TestMethod]
        public void TestEquazioneDiPrimoGradoImpossibile2()
        {
            double a = 0, b = 0;
            bool valoreAspettato = false;
            bool ValoreRitorno = Equazioni.isIncosisted(a, b);
            Assert.AreEqual(valoreAspettato, ValoreRitorno);

        }
        [TestMethod]
        public void TestEquazioneDiPrimoGradoImpossibile3()
        {
            double a = 6, b = 0;
            bool valoreAspettato = false;
            bool ValoreRitorno = Equazioni.isIncosisted(a, b);
            Assert.AreEqual(valoreAspettato, ValoreRitorno);

        }
        [TestMethod]
        public void TestEquazioneSecondoGrado()
        {
            double a = 6;
            bool valoreAspettato = true;
            bool ValoreRitorno = Equazioni.isDegree2(a);
            Assert.AreEqual(valoreAspettato, ValoreRitorno);
        }
        [TestMethod]
        public void TestEquazioneSecondoGrado1()
        {
            double a = 0;
            bool valoreAspettato = false;
            bool ValoreRitorno = Equazioni.isDegree2(a);
            Assert.AreEqual(valoreAspettato, ValoreRitorno);
        }
        [TestMethod]
        public void TestEquazioneSecondoDelta()
        {
            double a = 3, b = 4, c = 7;

            double valoreAspettato = -68;
            double ValoreRitorno = Equazioni.Delta(a,b,c);
            Assert.AreEqual(valoreAspettato, ValoreRitorno);
        }
        [TestMethod]
        public void TestEquazioneSecondoDelta2()
        {
            double a = 4, b = 7, c =-7;

            double valoreAspettato = 161;
            double ValoreRitorno = Equazioni.Delta(a, b, c);
            Assert.AreEqual(valoreAspettato, ValoreRitorno);
        }
        [TestMethod]
        public void TestEquazioneSecondoDeltaNullo()
        {
            double a = 4, b = -4, c = 1;

            double valoreAspettato = 0;
            double ValoreRitorno = Equazioni.Delta(a, b, c);
            Assert.AreEqual(valoreAspettato, ValoreRitorno);
        }
        [TestMethod]
        public void TestEquazioneSecondoCompleta()
        {
            double a = 1, b = 2, c = 1;

            string valoreAspettato = $"{-1}";
            string ValoreRitorno = Equazioni.Eq2Grado(a, b, c);
            Assert.AreEqual(valoreAspettato, ValoreRitorno);
        }
        [TestMethod]
        public void TestEquazioneSecondoCompleta2()
        {
            double a = 2, b = 5, c = 2;

            string valoreAspettato = $"{-0.5}-{-2}";
            string ValoreRitorno = Equazioni.Eq2Grado(a, b, c);
            Assert.AreEqual(valoreAspettato, ValoreRitorno);
        }
    }
}
