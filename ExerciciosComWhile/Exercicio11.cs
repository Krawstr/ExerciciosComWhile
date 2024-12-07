using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComWhile
{
    internal class Exercicio11
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Digite um número de 1 a 100");
            int numero =  Convert.ToInt16(Console.ReadLine());

            while (numero > 100)
            {

                Console.WriteLine("Digite um número valido");
                numero = Convert.ToInt16(Console.ReadLine());

            }

        }
    }
}