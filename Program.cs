using System;

namespace md04_CadernoExercicios_03
{
    class Program
    {
        /*
         3. Sem utilizar a operação de multiplicação, escreva um programa que multiplique dois
        números inteiros.
        Por exemplo: 2 * 2 = 2 + 2.
        3 * 4 = 4 + 4 + 4
         */
        
        static void Main(string[] args)
        {
            string s = "n";
            do
            {
                int nrDigitado, multiplicadoPor, res = 0, soma = 0, i = 1;
                Console.WriteLine("\n####################################################");
                Console.WriteLine("                   Multiplicação:                     ");
                Console.WriteLine("\n Digite o primeiro numero para ser multiplicado:");
                nrDigitado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n Digite o segundo numero para ser multiplicado:");
                multiplicadoPor = Convert.ToInt32(Console.ReadLine());

                for (i = 1; i <= multiplicadoPor; i++)
                {
                    soma = soma + nrDigitado;

                }
                res = soma;
                Console.WriteLine("{0} x {1} = {2} ", nrDigitado.ToString("0,0"), multiplicadoPor.ToString("0,0"), res.ToString("0,0"));
                Console.WriteLine("\nDeseja fechar a Calculadora:\nDigite (s) para sair ou (n) para continuar!");
                s = Console.ReadLine();
            } while (s == "n");
            Console.WriteLine("\n####################################################");
        }
    }
}
