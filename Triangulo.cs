using System;
using teste;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            double a, b, c;
            Console.Write("digitar Area do Triangulo: X");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            x =new Triangulo(a,b,c);
            Console.Write("digitar Area do Triangulo: Y");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            y = new Triangulo(a, b, c);


            Console.WriteLine("Area do triangulo x: " + x.areaTriangulo());
            Console.WriteLine("Area do triangulo x: " + y.areaTriangulo());
            x.maior(x.areaTriangulo(),y.areaTriangulo());



        }
       
    }
}


namespace teste
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;
        public Triangulo(double a,double b,double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double areaTriangulo()
        {
            double p = (A+B+C) / 2;
            double area = Math.Sqrt(p*(p-A)*(p-B)*(p-C));
            
            return area;
        }
        public void maior(double a,double b)
        {
            if (a > b)
            {
                Console.WriteLine("Area do Triangulo X é maior");
            }else
                Console.WriteLine("Area do Triangulo Y é maior");
        }
    }
}