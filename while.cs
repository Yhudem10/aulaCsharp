using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 10;
            while (n  > 0)
            {
                Console.Write("Digite um numero: ");
                 n = double.Parse(Console.ReadLine());
                if (n < 0) {
                    Console.WriteLine("Numero negativo: "+ n);
                }else
                Console.WriteLine(Math.Sqrt(n).ToString("F3"));

            }
        }
           

    }
}