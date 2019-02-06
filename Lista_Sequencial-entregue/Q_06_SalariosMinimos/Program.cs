using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_06_SalariosMinimos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 6. Faça um programa que receba o valor do salário mínimo 
             * e o valor do salário de um funcionário, calcule e mostre 
             * a quantidade de salários mínimos que ganha esse funcionário.
            */
            Console.WriteLine(":::          Quantos Salários Minimos?           :::");
            Console.WriteLine("::: -------------------------------------------- :::");
            // Solicitar input do usuário
            Console.WriteLine(":::   Informe o atual valor do Salário Mínimo    :::");
            // receber valor e converter para Double
            double salarioMin = Convert.ToDouble(Console.ReadLine());
            // Solicitar input do usuário
            Console.WriteLine("::: Informe o valor do Salário deste Funcionário :::");
            // receber valor e converter para Double
            double salarioFun = Convert.ToDouble(Console.ReadLine());

            // calcular a proporção e formatar para duas casas decimais
            double resultado =  salarioFun / salarioMin;

            // imprimindo resultado no console
            Console.WriteLine("::: -------------------------------------------- :::");
            /*
             * Caro professor Tiago Hofman,
             * para mostrar o resultado com duas casas decimais após a vírgula
             * encontrei essa solução 'System.Globalization.CultureInfo.InvariantCulture'
             * nos docs da Microsoft...
             * https://docs.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings
             * mas ainda acho meio complicado pra uma coisa tão simples.
             * Se tiver algo que eu possa usar pra agilizar esse tipo de operação agradeço a instrução.
             */

            Console.WriteLine(" Este funcionário recebe:  " + 
                resultado.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) 
                + " salários mínimos");

            // Instrução para o usuário encerrar
            Console.WriteLine("::: -------------------------------------------- :::");
            Console.WriteLine(":::           Qualquer tecla para sair           :::");
            Console.WriteLine("::: -------------------------------------------- :::");
            Console.ReadKey();
        }
    }
}
