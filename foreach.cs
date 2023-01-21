using aula;
using System;

namespace Course // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Jonas","Maria","Priscila"};
            foreach (string i in vect)
            {
                Console.WriteLine(i);
            }
        }
    }
}