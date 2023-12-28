using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_CSharp_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. A fórmula de conversão é:

            //  F = (9 * C + 160) / 5, sendo F a temperatura em Fahrenheit e C a temperatura em Celsius. Crie um algoritmo para isso.

            double C, F;

            Console.WriteLine("Qual a temperatura em graus Celsius?");
            C = double.Parse(Console.ReadLine());

            F = (9 * C + 160) / 5;

            Console.WriteLine("O resultado em graus Fahrenheit é: " + F);
            Console.ReadKey();
        }
    }
}
