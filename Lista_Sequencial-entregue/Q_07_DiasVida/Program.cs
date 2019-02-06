using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_07_DiasVida
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 7. Crie um programa que receba a data de nascimento de uma pessoa 
             * e calcule quantos dias, aproximados, ela já viveu até hoje    */
            Console.WriteLine(":::                   Dias de Vida               :::");
            Console.WriteLine(":::           Informe a data de nascimento       :::");
            Console.WriteLine("::: use o formato dd/mm/aaaa digitando as barras :::");
            Console.WriteLine("::: -------------------------------------------- :::");
            // variável 'dataNasc' recebe a digitação do usuário e converte para o tipo DateTime
            DateTime dataNasc = Convert.ToDateTime(Console.ReadLine());

            // calcular a diferença entre a data atual (método Today)
            // e a data do nascimento em dias
            System.TimeSpan diferenca = DateTime.Today - dataNasc;

            /* imprime o resultado da diferença entre a data atual e a data inicial em dias
            * para imprimir apenas os dias usamos o método 'ToTotalDays' sobre a variável diferença.
           * Sem esse ToTotalDays a impressão fica no formato completo de tempo dd.00:00:00
           */
            Console.WriteLine("::: -------------------------------------------- :::");
            Console.WriteLine("        O tempo vivido até hoje foi " + diferenca.TotalDays + " dias");
            // Instrução para o usuário encerrar
            Console.WriteLine("::: -------------------------------------------- :::");
            Console.WriteLine(":::           Qualquer tecla para sair           :::");
            Console.WriteLine("::: -------------------------------------------- :::");
            Console.ReadKey();
        }
    }
}
