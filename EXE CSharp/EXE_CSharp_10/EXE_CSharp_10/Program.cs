using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_CSharp_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10. A Loja Mamão com Açúcar está vendendo seus produtos em 5 (cinco)
            //prestações sem juros.
            //Faça um algoritmo que receba um valor de uma compra e mostre o
            //valor das prestações.

            double prod, prest;

            Console.WriteLine("Digite o valor da compra:");
            prod = double.Parse(Console.ReadLine());


            prest = prod / 5;
            Console.WriteLine("O valor da prestação é: " + prest);
            Console.ReadKey();
        }
    }
}
