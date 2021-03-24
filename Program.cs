using System;

namespace _04_RandomVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor v = new Vetor(20);
            int x;
           
            v.imprimirVetor();

            Console.WriteLine("\nDIGITE O VALOR X: ");
            x = int.Parse(Console.ReadLine());
           
            v.MaiorMenor();
            v.PrimeiraOcorrencia(x);
            v.PosiçoesOcorrencia(x);
            v.numerodeOcorrencias(x);



        }

    }
}
