using System;
using teste;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            Console.Write("Entre com Valor do Raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circurferencia(raio);
            double volume =Calculadora.Volume(raio);
            Console.WriteLine("Raio è: "+raio);
            Console.WriteLine("Circuferncia é: "+circ.ToString("F2"));
            Console.WriteLine("Volume é: "+volume.ToString("F2"));
            Console.WriteLine("Valor de PI: "+Calculadora.PI);


        }
    }
}


namespace teste
{
    internal class Calculadora
    {
       public static double PI = 3.14;
       public static double Circurferencia(double r)
        {
            return 2.0 * PI * r;
        }
       public static double Volume(double r)
        {
            return 4.0 / 3.0 * PI * r * r * r;
        }
    }
}