using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComWhile
{
    internal class Exercicio4
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite o número que seja ver a tabuada de 1 a 10");
            int numero = Convert.ToInt16(Console.ReadLine());
            int contadora = 1;


            while (contadora < 11)
            {
                {
                    Console.WriteLine($"{contadora} x {numero} = {contadora * numero}");
                    contadora++;

                }
            }
        }
    }
}