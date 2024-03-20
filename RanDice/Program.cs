using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            
        if (args.Length < 2)
        {
            Console.WriteLine("Uso: dotnet run --project RanDice -- <número de dados> <semente>");
            return;
        }

        if (!int.TryParse(args[0], out int n) || !int.TryParse(args[1], out int s))
        {
            Console.WriteLine("Os argumentos fornecidos não são válidos.");
            return;
        }

        }
    }
}
