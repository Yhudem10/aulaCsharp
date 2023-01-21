using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int I = int.Parse(valores[0]);
            int F = int.Parse(valores[1]);

            if (I<F)
            {
                int res = F - I;
                Console.WriteLine("Jogo Durou: "+res);

            }
            else
            {
                int res = 24-I + F;
                Console.WriteLine("Jogo Durou: " + res);
            }
        }
    }
}