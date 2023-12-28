using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_CSharp_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elaborar um algoritmo que efetue a apresentação do valor da
            // conversão em real(R$) de um valor lido em dólar(US$). 
            // O algoritmo deverá solicitar o valor da cotação do dólar e, também a quantidade de dólares disponíveis com o usuário.

            double D, R, cota;

            Console.WriteLine("Digite o valor da cotação do Dólar:");
            cota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de Dólar disponivel:");
            D = double.Parse(Console.ReadLine());

            R = cota * D;

            Console.WriteLine("o valor em real é: " + R.ToString("c"));
            Console.ReadKey();

        }
    }
}
