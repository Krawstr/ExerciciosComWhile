using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComWhile
{
    internal class Exercicio2
    {
        public static void Main(string[] args)
        {
            int numero = 0;
            int somaNumeros = 0;

            while (true)
            {
                Console.WriteLine("Digite um numero");
                numero = Convert.ToInt16(Console.ReadLine());
                somaNumeros += numero;
                
                if (numero == 0)
                {
                    break;
                }


            }
            Console.WriteLine($"A soma total dos números é de: {somaNumeros}");
        }
    }
}
