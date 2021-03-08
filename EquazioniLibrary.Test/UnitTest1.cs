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
            string valoreRitorno = Equazioni.Eq2Grado(a, b, c);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void TestEquazioneSecondoCompleta3()
        {
            double a = 4, b = 2, c =4 ;

            string valoreAspettato = $"non ha punti di intersezione";
            string valoreRitorno = Equazioni.Eq2Grado(a, b, c);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void TestEquazioneDiPrimoGrado1()
        {
            double a = 0, b = 0;
            string valoreAspettato = "indeterminato";
            string valoreRitorno = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void TestEquazioneDiPrimoGrado2()
        {
            double a = 3, b = 6;
            string valoreAspettato = $"{2}";
            string valoreRitorno = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void TestEquazioneDiPrimoGrado3()
        {
            double a = 9, b = 5;
            string valoreAspettato = $"impossibile";
            string valoreRitorno = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void TestIsConsistedArefalse()
        {
            int a = 8, b = 0;
            bool risposta = Equazioni.isIncosisted(a, b);
            Assert.IsFalse(risposta);
        }
        [TestMethod]
        public void TestIsConsistedAreTrue()
        {
            int a = 2, b = 3;
            bool risposta = Equazioni.isIncosisted(a, b);
            Assert.IsTrue(risposta);
        }
        [TestMethod]
        public void TestIsDegreeTrue()
        {
            int a = 2;
            bool risposta = Equazioni.isDegree2(a);
            Assert.IsTrue(risposta);
        }
        [TestMethod]
        public void TestIsDegreeFalse()
        {
            int a = 0;
            bool risposta = Equazioni.isDegree2(a);
            Assert.IsFalse(risposta);
        }
        [TestMethod]
        public void TestIsDeterminatedTrue()
        {
            int a = 3;
            bool risposta = Equazioni.IsDeterminated(a);
            Assert.IsTrue(risposta);
        }
        [TestMethod]
        public void TestIsDeterminatedFalse()
        {
            int a = 0;
            bool risposta = Equazioni.IsDeterminated(a);
            Assert.IsFalse(risposta);
        }

    }
}
