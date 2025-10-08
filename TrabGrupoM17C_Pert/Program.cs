using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]maeros = new int[10];
            
            for (int i = 0; i < maeros.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                maeros[i] = int.Parse(Console.ReadLine());
            }

            int maximo = maeros[0];
            int indice = 0;
            Console.WriteLine("maximo (1).", maximo);
            Console.WriteLine("indice (1).", indice);

            for (int i = 1; i < maeros.Length; i++)
            {
                if (maeros[i] > maximo)
                {
                    maximo = maeros[i];
                    indice = i;
                }
                Console.WriteLine("Maior numero {0} e indice (1)",maximo,indice);
                Console.WriteLine("******************");
            }
        }
    }
}
