using System;
using teste;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1= new Pessoa();
            p2= new Pessoa();
            
            Console.Write("digitar Nome da P1: ");
            p1.setNome(Console.ReadLine());
            Console.Write("digitar Idade da P1: ");
            p1.setIdade(int.Parse(Console.ReadLine()));
            Console.Write("digitar Nome da P2: ");
            p2.setNome(Console.ReadLine());
            Console.Write("digitar Idade da P2: ");
            p2.setIdade(int.Parse(Console.ReadLine()));


            p1.maiorIdade(p1,p2);



        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Pessoa
    {
        string nome;
        int idade;
        public Pessoa() {
            string nome;
            int idade;
        
        }

        public string getNome()
        {
            return nome;
        }
        public int getIdade() {
            return idade;
        }
        public void setNome(string n)
        {
            nome = n;
        }
        public void setIdade(int i)
        {
            idade = i;
        }
        public void maiorIdade(Pessoa p1,Pessoa p2)
        {
            if (p1.getIdade() > p2.getIdade())
            {
                Console.WriteLine(p1.getNome()+" Tem maior Idade "+p1.getIdade());
            }else
                 Console.WriteLine(p2.getNome() + " Tem maior Idade " + p2.getIdade());

        }
    }
}
