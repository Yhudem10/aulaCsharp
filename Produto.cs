using System;
using teste;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entres com a com os dados do  produto");
            Console.Write("Nome: ");
            string nome=Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int qt = int.Parse(Console.ReadLine());
            Produto p = new (nome,preco,qt);
            Console.WriteLine(p);
            Console.WriteLine("Digite a quantidade de Produto a ser adcionado: ");
            p.adicionarProduto(int.Parse(Console.ReadLine()));
            Console.WriteLine(p);
            Console.WriteLine("Digite a quantidade de Produto a ser Removido: ");
            p.removerProduto(int.Parse(Console.ReadLine()));
            Console.WriteLine(p);




        }
    }
}



using System.Net;
using System.Threading.Tasks.Sources;

namespace teste
{
    internal class Produto
    {
        string nome;
        double valor;
        int quantidade;
        double valorTotal;
        public Produto(string n,double p,int q) {
            nome = n;
            valor = p;
            quantidade = q;
            valorTotal = q * p;
        }
        public void adicionarProduto(int q)
        {
            quantidade=q +quantidade ;
            valorTotal = quantidade * valor;

        }
        public void removerProduto(int q)
        {
            quantidade = quantidade-q;
            valorTotal = quantidade * valor;
        }
       
        public override string ToString()
        {
            return nome 
                + " $" 
                + valor.ToString("F2") 
                + " Quatidade: " 
                + quantidade 
                + " Valor Total no Estoque:" 
                + valorTotal.ToString("F2");
        }
    }
}
