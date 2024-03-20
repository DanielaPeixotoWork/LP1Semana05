using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {

        if (args.Length == 0)
            {
                Console.WriteLine("Digite o número de inimigos");
                return;
            }

            if (!int.TryParse(args[0], out int numEnemies))
            {
                Console.WriteLine("O número de inimigos especificado não é válido.");
                return;
            }
            
        }
    }
}
