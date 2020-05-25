using System;
namespace Hexapawn
{
    public class Joueur
    {
        public string nom;
        public string pion;
        public SensDeJeu sensDeJeu;

        private const int incrementDeDeplacement = 1;

        public Joueur(string nom, string pion)
        {
            this.nom = nom;
            this.pion = pion;
        }

        public int IncrementDeplacement
        {
            get {
                if (sensDeJeu == SensDeJeu.BasVersHaut)
                {
                    return -1 * incrementDeDeplacement;
                }

                return incrementDeDeplacement;
            }
        }
    }
}
