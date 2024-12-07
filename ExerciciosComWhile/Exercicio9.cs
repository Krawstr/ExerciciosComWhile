using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComWhile
{
    internal class Exercicio9
    {
        public static bool EhPrimo(int n)
        {
            if (n <= 1)
            {
                return false; 
            }

            int i = 2;
            while (i <= Math.Sqrt(n))
            {
                if (n % i == 0)
                {
                    return false; 
                }
                i++;
            }

            return true; 
        }

        public static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine()); 

            if (EhPrimo(numero))
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }
        }
    }
}





