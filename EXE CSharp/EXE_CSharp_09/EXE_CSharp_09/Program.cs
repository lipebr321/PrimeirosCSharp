using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_CSharp_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que receba um valor que foi
            //depositado e exiba o valor com rendimento após um mês.
            //Considere fixo o juro da poupança em 0,70 % a.m.

            double dep, rend, rendm;

            Console.WriteLine("Digite o valor depositado:");
            dep = double.Parse(Console.ReadLine());

            rend = dep * (0.70/100);
            rendm = rend + dep;

            Console.WriteLine("O valor rende no mês : " + rendm);
            Console.ReadKey();
        }
    }
}
