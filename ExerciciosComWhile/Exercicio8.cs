using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComWhile
{
    internal class Exercicio8
    {
        public static int contagemVogais(string letra)
        {

            int n = 0;

            if (letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
            {
                n += 1;

            }
            return n;

        }

        public static void Main(string[] args)
        {
            int contagem = 0;
            while (true)
            {
                Console.WriteLine("Digite uma vogal (ou digite FIM para sair) ");
                string letra = Console.ReadLine().ToUpper();

                if (letra == "FIM")
                {

                    break;
                }

                contagem += contagemVogais(letra);

            }

            Console.WriteLine($"Você digitou: {contagem} vogais");

        }
    }
}