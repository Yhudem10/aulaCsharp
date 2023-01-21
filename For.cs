using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros interiros vai digitar: ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= n; i++)
            {

                Console.Write("Valor #"+i+": ");
                soma= int.Parse(Console.ReadLine())+soma;
            }
            Console.WriteLine("Soma é: "+soma);



        }
    }
}

