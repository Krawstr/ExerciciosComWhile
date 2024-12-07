using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComWhile
{
    internal class Exercicio6
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite um operador [+, -, *, / ou sair]");
                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "SAIR")
                {
                    Console.WriteLine("finalizado");
                    break;
                }
            }
        }
    }
}
