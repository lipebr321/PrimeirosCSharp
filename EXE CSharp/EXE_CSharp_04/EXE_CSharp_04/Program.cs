using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_CSharp_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo que leia o nome de um vendedor, 
            //o seu salário fixo e o total de vendas efetuadas por ele no mês(em dinheiro).
            //Sabendo que este vendedor ganha 15 % de comissão sobre suas vendas efetuadas, 
            //informar o seu nome, o salário fixo e salário no final do mês.

            string vendedor;
            double salfix, comic, salfinal;

            Console.WriteLine("Por favor, digite o nome do vendedor(a):");
            vendedor = Console.ReadLine();

            Console.WriteLine("Agora digite o salario fixo do vendedor(a):");
            salfix = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi o faturamento em dinheiro realizado pelo vendedor(a):");
            comic = double.Parse(Console.ReadLine());

            comic = comic * 15 / 100;
            salfinal = salfix + comic;

            Console.WriteLine("O salario fixo de " + vendedor + " é: " + salfix + ", e com sua comição do mês ficou:" + salfinal);
            Console.ReadKey();

        }
    }
}
