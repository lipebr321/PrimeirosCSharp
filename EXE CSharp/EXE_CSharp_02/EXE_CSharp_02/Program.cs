using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_CSharp_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que receba dois números e ao final mostre a soma, subtração, multiplicação e a divisão dos números lidos

            double num1, num2, soma, mult, div, sub;

            Console.WriteLine("Usuário, digite o primeiro numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Usuário, digite o segundo numero: ");
            num2 = double.Parse(Console.ReadLine());

            soma = num1 + num2;
            div = num1 / num2;
            sub = num1 - num2;
            mult = num1 * num2;

            Console.WriteLine("O resultado da soma dos dois numeros é: " + soma);
            Console.WriteLine("O resultado da subtração do primeiro numero pelo segundo numero é: " + sub);
            Console.WriteLine("O resultado da multiplicação dos dois numeros é: " + mult);
            Console.WriteLine("O resultado da divisão do primeiro numero pelo segundo numero é: " + div);

            Console.ReadKey();

        }
    }
}
