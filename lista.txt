      List<string> list = new List<string>();
            int n = 1;
            while (n == 1)
            {
                Console.WriteLine("Digite um nome: ");
                list.Add(Console.ReadLine());
                Console.WriteLine("Continuar ? 1=Sim");
                n = int.Parse(Console.ReadLine());
            }


            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Tamanho da Lista: "+list.Count());
            Console.WriteLine();
        }