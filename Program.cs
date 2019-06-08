using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAlunos = 0;
            float somaAlunos = 0;
            float mediaAlunos = 0;
            float menor = 0;
            float maior = 0;
            float[] alunosArray;

            Console.WriteLine("informe a quantidade de alunos:");
            numAlunos = int.Parse(Console.ReadLine());

            alunosArray = new float[numAlunos];

            for (int i = 0; i < numAlunos; i++)
            {
                Console.WriteLine("informe a media do aluno " + (i+1)+ ":");
                alunosArray[i] = float.Parse(Console.ReadLine());

            }

            for (int i = 0; i < numAlunos; i++)
            {
                somaAlunos += alunosArray[i];
            }

            mediaAlunos = (somaAlunos / alunosArray.Length);

            for (int i = 0; i < numAlunos; i++)
            {
                if(i==0)
                {
                    menor = alunosArray[0];
                    maior = alunosArray[0];
                }
                if (alunosArray[i]< menor)
                {
                    menor = alunosArray[i];

                }
                if (alunosArray[i] > maior)
                {
                    maior = alunosArray[i];

                }

            }
            Console.WriteLine("A media geral dos alunos é: " + mediaAlunos);
            Console.WriteLine("A menor nota é: " + menor);
            Console.WriteLine("A maior nota é: " + maior);


            Console.WriteLine("");
            Console.ReadLine();

        }   } 
}
