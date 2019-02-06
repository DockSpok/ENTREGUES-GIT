using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_03_Losango
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3. Faça um programa que calcule e mostre a área de um losango 
             * AREA = (DIAGONAL MAIOR * DIAGONAL MENOR)/2
             */
            Console.WriteLine(":::          <>  Área de um Losango  <>          :::");
            Console.WriteLine(":::            A = dMenor X dMaior / 2           :::"); 
            Console.WriteLine("::: -------------------------------------------- :::");
            // Solicitar input do usuário
            Console.WriteLine(":::       Informe a medida da diagonal menor     :::");

            // declarando variáveis como tipo 'double' e recebendo os inputs.
            // convertendo imediatamente o input do usuário para o tipo 'double'

            double dMenor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(":::       Informe a medida da diagonal maior     :::");
            double dMaior = Convert.ToDouble(Console.ReadLine());

            // calculando a área e atribuindo o valor à variável 'area'
            double area = dMenor * dMaior / 2;

            // imprimindo resultado no console
            Console.WriteLine("           A área do Losango é :       " + area);

            // Instrução para o usuário encerrar
            Console.WriteLine("::: -------------------------------------------- :::");
            Console.WriteLine(":::           Qualquer tecla para sair           :::");
            Console.WriteLine("::: -------------------------------------------- :::");
            Console.ReadKey();
        }
    }
}
