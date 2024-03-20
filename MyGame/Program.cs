using System;

namespace MyGame
{
    public enum PowerUp
    {
        Health,
        Shield
    }

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

            Enemy[] enemies = new Enemy[numEnemies];

            for (int i = 0; i < numEnemies; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string name = Console.ReadLine();

                enemies[i] = new Enemy(name);
            }

            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");
            }   
        }
    }
}
