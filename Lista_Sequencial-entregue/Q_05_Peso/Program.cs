using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_05_Peso
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Faça um programa que receba o peso de uma pessoa, calcule e mostre:
            // a.O seu novo peso, se a pessoa engordar 15 % sobre o peso digitado
            // b.O seu novo peso, se a pessoa emagrecer 20 % sobre o peso digitado
            // declarando variaveis
            double pesoInicial, diferenca, novoPeso;
            Console.WriteLine("::: Planejamento de Peso :::");
            Console.WriteLine("Informe o peso inicial: ");
            // Recebendo a digitação do usuário e convertendo para o tipo double
            pesoInicial = Convert.ToDouble(Console.ReadLine());
            // Calculo do percentual de aumento
            diferenca = pesoInicial * 0.15;
            // Calculo do novo peso atribuindo a soma à variavel novoPeso
            novoPeso = pesoInicial + diferenca;
            // Imprimindo o resultado
            Console.WriteLine("A) Com o aumento de 15% o novo peso será: " + novoPeso +
                               " kg. Terá aumentado: " + diferenca + "kg");
            // Calculo do percentual de redução
            diferenca = pesoInicial * 0.20;
            // Calculo do novo peso atribuindo a diferença à variavel novoPeso
            novoPeso = pesoInicial - diferenca;
            // Imprimindo o resultado
            Console.WriteLine("B) Com a redução de 20% o novo peso será: " + novoPeso +
                            " kg. Terá diminuido: " + diferenca + "kg");
            // Instrução para o usuário encerrar
            Console.WriteLine("::: ------------------------ :::");
            Console.WriteLine("::: Qualquer tecla para sair :::");
            Console.WriteLine("::: ------------------------ :::");
            Console.ReadKey();
        }
    }
}
