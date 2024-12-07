using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComWhile
{
    internal class Exercicio13
    {
        public static void Main(string[] args)
        {
            int somador = 0;

            while (true)
            {

                Console.WriteLine("Digite um número");
                int n = Convert.ToInt16(Console.ReadLine());

                if (n == 0)
                {

                    break;

                }
                else if (n % 2 == 0) {

                    somador += n;

                }

            }

            Console.WriteLine("");

        }
    }
}