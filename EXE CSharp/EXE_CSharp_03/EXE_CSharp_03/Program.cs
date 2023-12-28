using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_CSharp_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo para determinar o consumo médio de um 
            //automóvel sendo fornecida a distância total percorrida pelo 
            //automóvel e o total de combustível gasto.

            double comb, dist, cons;

            Console.WriteLine("Olá seja bem vindo ao sistema de consumo médio de combustivel!");
            Console.WriteLine("Por favor! Digite a quantidade de KM percorrido pelo veiculo:");
            dist = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora, digite quantos litros foram gastos no percurso realizado:");
            comb = double.Parse(Console.ReadLine());

            cons = dist / comb;

            Console.WriteLine("O consumo médio do seu veiculo é: " + cons + " KM por litro");
            Console.ReadKey();
        }
    }
}
