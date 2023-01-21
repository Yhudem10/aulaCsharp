using System;

namespace Course // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            int tmp = 0;
            Console.WriteLine("Quantas entradas: ");
            tmp = int.Parse(Console.ReadLine());
            double[] vector = new double[tmp];
            double soma= 0;
            double media;
            for (int i = 0; i < tmp; i++)
            {
                Console.WriteLine("digite valor pra vetor: "+i);
                vector[i]=double.Parse(Console.ReadLine());
                soma = vector[i] + soma;
                
            }
            media = soma / tmp;
            Console.WriteLine("Media  é " + media.ToString("F2"));
        }
    }
}