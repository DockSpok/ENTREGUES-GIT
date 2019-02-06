using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_01_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Faça um programa que calcule e mostre a tabuada de multiplicação 
            //   de um número digitado pelo usuário
            // Escreve na tela do console.
            Console.WriteLine("::: Digite um número para ver a tabuada até 10 :::");
            // Lê a resposta do usuário a partir do console e transforma para o tipo double
            // na mesma linha a variável 'num' é declarada com o tipo double e
            // em seguida recebe o valor por input pelo ReadLine e o converte 'ToDouble'
            double num = Convert.ToDouble(Console.ReadLine());
            // a seguir cada linha calcula e escreve no console o resultado de uma operação
            Console.WriteLine(" 1 X " + num + " = " + (num * 1));
            Console.WriteLine(" 2 X " + num + " = " + (num * 2));
            Console.WriteLine(" 3 X " + num + " = " + (num * 3));
            Console.WriteLine(" 4 X " + num + " = " + (num * 4));
            Console.WriteLine(" 5 X " + num + " = " + (num * 5));
            Console.WriteLine(" 6 X " + num + " = " + (num * 6));
            Console.WriteLine(" 7 X " + num + " = " + (num * 7));
            Console.WriteLine(" 8 X " + num + " = " + (num * 8));
            Console.WriteLine(" 9 X " + num + " = " + (num * 9));
            Console.WriteLine("10 X " + num + " = " + (num * 10));
            // Instrução de saída para o usuário
            Console.WriteLine("::: Qualquer tecla para sair :::");
            // Instrução para a execução esperar ação do usuário
            Console.ReadKey();
        }
    }
}
