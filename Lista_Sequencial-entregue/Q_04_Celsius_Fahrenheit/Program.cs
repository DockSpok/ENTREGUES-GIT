using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_04_Celsius_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 4. Faça um programa que receba uma temperatura em Celsius, 
             * calcule e mostre essa temperatura em Fahrenheit. 
             *   F = (C*1,8) + 32
            */
            Console.WriteLine(":::            Convesor de Temperatura           :::");
            Console.WriteLine(":::   CELSIUS p FAHRENHEIT   F = (C*1,8) + 32    :::");
            Console.WriteLine("::: -------------------------------------------- :::");
            // Solicitar input do usuário
            Console.WriteLine(":::    Informe a temperatura em graus Celsius    :::");

            // declarando variáveis como tipo 'double' e recebendo os inputs.
            // convertendo imediatamente o input do usuário para o tipo 'double'

            double tempCelcius = Convert.ToDouble(Console.ReadLine());

            // calculando a área e atribuindo o valor à variável 'area'
            double tempFahrenheit = ( tempCelcius * 1.8 ) + 32; 

            // imprimindo resultado no console
            Console.WriteLine("      A temperatura em Fahrenheit é :   " + tempFahrenheit + "ºF");

            // Instrução para o usuário encerrar
            Console.WriteLine("::: -------------------------------------------- :::");
            Console.WriteLine(":::           Qualquer tecla para sair           :::");
            Console.WriteLine("::: -------------------------------------------- :::");
            Console.ReadKey();
        }
    }
}
