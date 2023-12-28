using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_CSharp_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo que leia o nome de um aluno e as notas das
            //três provas que ele obteve no semestre. No final informar o nome 
            //do aluno e a sua média(aritmética).

            string nome;
            double nt1, nt2, nt3, media;

            Console.WriteLine("Vamos ajudar você a calcular a média do aluno!");
            Console.WriteLine("Digite o nome do aluno:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota:");
            nt1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            nt2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            nt3 = double.Parse(Console.ReadLine());

            media = (nt1 + nt2 + nt3) / 3;

            Console.WriteLine("A média do aluno " + nome + " foi: " + media);
            Console.ReadKey();
        }
    }
}
