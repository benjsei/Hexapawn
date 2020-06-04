using System;
namespace Hexapawn.Jeu
{
    public class Aleatoire : IAleatoire
    {
        private readonly Random Random = new Random();
        private const int vraiOuFauxPossibilite = 2;
        private const int vraiOuFauxSolution = 1;

        public int ChiffreAleatoire(int max)
        {
            return Random.Next() % max;
        }

        public bool VraiOuFauxAleatoire()
        {
            return ChiffreAleatoire(vraiOuFauxPossibilite) == vraiOuFauxSolution;
        }
    }
}
