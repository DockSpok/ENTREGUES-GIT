using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_02_Neg_Pos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 2. Crie um programa que receba como entrada um número negativo qualquer 
             * e transforme este número em positivo
             */
            Console.WriteLine(":::    Transformar número negativo em positivo   :::");
            Console.WriteLine("::: -------------------------------------------- :::");

            Console.WriteLine(":::       insira um número negativo qualquer     :::");
            double neg = Convert.ToDouble(Console.ReadLine());
            double pos = neg * -1;

            Console.WriteLine("    O equivalente positivo de ( " + neg + " ) é ( " + pos + " )");

            // Instrução para o usuário encerrar
            Console.WriteLine("::: -------------------------------------------- :::");
            Console.WriteLine(":::           Qualquer tecla para sair           :::");
            Console.WriteLine("::: -------------------------------------------- :::");
            Console.ReadKey();
        }
    }
}
