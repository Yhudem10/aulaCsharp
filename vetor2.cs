using aula;
using System;

namespace Course // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de Produto:");
            int n = int.Parse(Console.ReadLine());
            Product[] vet = new Product[n];
            double soma = 0;

            for(int i = 0; i < n; i++)
            {
                Console.Write("Digeto nome do Produto:");
                string nome= Console.ReadLine();
               
                Console.Write("Digite Preço do Produto:");
                 double preco= double.Parse(Console.ReadLine());
                vet[i] = new Product(nome, preco);
                soma = soma + vet[i].Price;
            }
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("----Produto---- " + i);
                Console.Write(vet[i].ToString());
                Console.WriteLine("");
                Console.WriteLine("--------------- ");
            }
            Console.WriteLine("Soma de Tudo: "+soma);
           
            }
        }
    }


using System.Drawing;

namespace aula
{
    internal class Product
    {
       
        public string Name { get; set; }
        public double Price { get; set; }

        public int  Quantiti{ get; set; }
        public Product(string nome, double preco)
        {
            Name = nome;
            Price = preco;

        }
        public override string ToString()
        {
            return Name
                + " $"
                + Price.ToString("F2")
                + " Quatidade: "
                + Quantiti;
        }
    }
}
