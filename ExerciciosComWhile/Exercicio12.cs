using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComWhile
{
    internal class Exercicio12
    {

        public static void Main(string[] args)
        {
            int contadoraPar = 0;
            int contadoraImpar = 0;


            while (true)
            {
                Console.WriteLine("Digite um número");
                int n = Convert.ToInt16(Console.ReadLine());

                if (n == 0) { 
                    break;
                
                } else if (n % 2 == 0)
                {

                    contadoraPar++;

                }
                else
                {
                    contadoraImpar++;

                }

            }

            Console.WriteLine($"Você digitou {contadoraPar} numeros pares e {contadoraImpar} numeros impares");

        }
    }
}
