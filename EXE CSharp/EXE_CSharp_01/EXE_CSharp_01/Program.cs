using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_CSharp_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;
            string nome;

            Console.WriteLine("Usuáio, digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Usuário, digite o primeiro numero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Usuário, digite o segundo numero:");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine("O nome do usuário é: " + nome);
            Console.WriteLine("O resultado da soma é: " + soma);

            Console.ReadKey();
        }
    }
}
