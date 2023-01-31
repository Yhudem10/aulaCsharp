internal class Program
{
    private static void Main(string[] args)
    {
        
        try
        {
            Console.WriteLine("Digite um dois numeros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int div = n1 / n2;
            Console.WriteLine("Valor da divisao é: " + div);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error: "+ex.Message);
            Console.WriteLine(ex);
        }
       
    }
}