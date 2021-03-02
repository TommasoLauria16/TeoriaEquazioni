using System;
using EquazioniLibrary;

namespace ProvaInConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equazione di primo grado se determinta");
            double coefficente = double.Parse(Console.ReadLine());
            bool vf = Equazioni.IsDeterminated(coefficente);
            Console.WriteLine($"l'equazione è determinata: {vf}");
            Console.WriteLine("Equazione di primo grado se determinta, inserire a e b");
            double a = double.Parse(Console.ReadLine());
            double b= double.Parse(Console.ReadLine());
            bool impossibile = Equazioni.isIncosisted(a, b);
            Console.WriteLine($"l'equazione è determinta: {impossibile}");
            Console.WriteLine("Equazione di secondo grado");
            double coefficenteA = double.Parse(Console.ReadLine());
            bool SecondoGrado = Equazioni.IsDeterminated(coefficenteA);
            Console.WriteLine($"l'equazione è determinata: {SecondoGrado}");
            Console.WriteLine("calcolo del delta");
            double delta1 = double.Parse(Console.ReadLine());
            double delta2 = double.Parse(Console.ReadLine());
            double delta3 = double.Parse(Console.ReadLine());
            double delta = Equazioni.Delta(delta1, delta2, delta3);
            Console.WriteLine($"il delta è {delta}");
            Console.WriteLine("Equazione di secondo gardo completa, a, b ,c ");
            double termine1 = double.Parse(Console.ReadLine());
            double termine2 = double.Parse(Console.ReadLine());
            double termine3 = double.Parse(Console.ReadLine());
            string eq2 = Equazioni.Eq2Grado(termine1, termine2, termine3);
            Console.WriteLine(eq2);
            Console.WriteLine("equazione di primo grado");
            double m = double.Parse(Console.ReadLine());
            double q = double.Parse(Console.ReadLine());
            string eq1 = Equazioni.EquationDegree1(m, q);
            Console.WriteLine(eq1);



        }

    }
}
