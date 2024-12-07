using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComWhile
{
    internal class Exercicio7
    {
        public static void Main(string[] args)
        {
            List<int> listaNumeros = [1, 5, 7, 10, 16, 13];
            Random numAleatorio = new Random();
            int sorteio = numAleatorio.Next(listaNumeros.Count);
            int numeroSorteado = listaNumeros[sorteio];
            int tentativa = 0;

            while (true)
            {
                Console.WriteLine("Faça seu chute");
                tentativa = Convert.ToInt16(Console.ReadLine());

                if (tentativa == numeroSorteado)
                {
                    Console.WriteLine($"O numero sorteado era: {numeroSorteado} e você acertou!");
                    break;
                }

            }

        }
    }
}
