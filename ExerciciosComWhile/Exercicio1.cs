using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComWhile
{
    internal class Exercicio1
    {
        public static void Main(string[] args)
        {

            int contadora = 1;

            while (contadora < 11)
            {
                Console.WriteLine(contadora++);
            }
        }
    }
}
