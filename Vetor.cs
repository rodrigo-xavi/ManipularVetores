using System;
using System.Collections.Generic;
using System.Text;

namespace _04_RandomVetores
{
    class Vetor
    {
        
        private int[] v;
        public Vetor (int x)
        {
           gerarVetor(x);
            
        }
        
        public void gerarVetor(int x )
        {
            this.v = new int[x];
            Random ale = new Random();
            

            for(int i = 0; i < v.Length; i++)
            {
                v[i] = ale.Next(1, 10);
            }

        }

        public void imprimirVetor()
        {
            Console.WriteLine("---------------------------- VETOR -----------------------------------");
            for(int i = 0; i < v.Length; i++)
            {
                Console.Write(" "+v[i]+" ");
            }
        }

        public void MaiorMenor()
        {
            int maior = 0;
            int menor = 0;
            Console.WriteLine(" \n ----------------- MAIOR E MENOR VALOR DO VETOR ------------------");
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > v[maior])

                {
                    maior = i;

                }
            }
            Console.WriteLine("MAIOR VALOR DO VETOR: " + v[maior]);
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < v[menor])

                {
                    menor = i;

                }
            }
            Console.WriteLine("MENOR VALOR DO VETOR: " + v[menor]);
        }


        public void PrimeiraOcorrencia( int p)
        {
            int i;
            Console.WriteLine(" \n----------------- POSIÇÃO DA PRIMEIRA OCORRÊNCIA DE X ------------------");
            for (i = 0; i < v.Length; i++)
            {
                if (v[i] == p)

                {
                    break;

                }
            }
            if (i < v.Length)
            {
                Console.WriteLine(i);
            }
            else
            {
                i = -1;

                Console.WriteLine("valor não encontrado");
            }
        }

        public void PosiçoesOcorrencia( int p)
        {
            int i ;
           
            Console.WriteLine(" \n----------------- POSIÇÕES DAS OCORRÊNCIA DE X ------------------");
           
            for (i = 0 ; i < v.Length; i++)
            {
                    if (v[i] == p)
                    {
                    
                      Console.WriteLine(i);
                    }
            }
        }

       public void numerodeOcorrencias(int p)
        {
            int cont=0, i;
            Console.WriteLine(" \n----------------- NUMERO DE OCORRÊNCIA DE X ------------------");
            for (i = 0; i < v.Length; i++)
            {
                if (v[i] == p)
                {
                    cont++;
                }
            }
            Console.WriteLine("Quantidade de ocorrencias do elemento X no vetor: "+cont);
            
        }
       
    }
}
