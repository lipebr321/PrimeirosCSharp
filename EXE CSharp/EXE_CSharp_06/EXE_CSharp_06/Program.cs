using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_CSharp_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler dois valores para as variáveis A e B, e efetuar as trocas dos valores de forma que a variável A 
            //passe a possuir o valor da variável B e a variável B 
            //passe a possuir o valor da variável A. Criar um algoritmo
            //para apresentar os valores trocados.

            int A, B, C;

            Console.WriteLine("Digite o valor de A:");
            A = int.Parse(Console.ReadLine());

            C = A;

            Console.WriteLine("Digite o valor de B:");
            B = int.Parse(Console.ReadLine());

            A = B;
            B = C;

            Console.WriteLine("Com as varíaveis trocadas ficou assim: A é " + A + ", B é " + B);
            Console.ReadKey();
        }
    }
}
