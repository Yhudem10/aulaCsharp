using aula;
using System;

namespace Course // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tempo");
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(" " + d1.ToLongDateString());
            Console.WriteLine("Dia da semana " + d1.DayOfWeek);
            Console.WriteLine("Dia ano " + d1.DayOfYear);
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);


        }

    }
}
