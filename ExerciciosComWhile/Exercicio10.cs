using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComWhile
{
    internal class Exercicio10
    {

        public static void Main(string[] args)
        {

            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            numero = Math.Abs(numero);

            int contador = 0;

            while (numero > 0)
            {
                numero /= 10; 
                contador++;   
            }

            if (contador == 0)
            {
                contador = 1;
            }

            Console.WriteLine($"O número digitado possui {contador} dígito(s).");
        }
    }
}