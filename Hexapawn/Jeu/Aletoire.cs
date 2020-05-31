using System;
namespace Hexapawn
{
    public class Aleatoire : IAleatoire
    {
        private readonly Random Random = new Random();

        public int ChiffreAleatoire(int max)
        {
            return Random.Next() % max;
        }
    }
}
