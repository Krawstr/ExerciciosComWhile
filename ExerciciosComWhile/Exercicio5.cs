using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComWhile
{
    internal class Exercicio5
    {
        public static void Main(string[] args)
        {
        
            while (true)
            {
                Console.WriteLine("Digite um número");
               int numero = Convert.ToInt16(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Finalizando...");
                    Thread.Sleep(1000);
                    Console.WriteLine("Finzalizado com sucesso");
                    break;


                }

            }
        }
    }
}
