using System;
namespace Hexapawn
{
    public class Joueur
    {
        public string nom;
        public string pion;
        public SensDeJeu sensDeJeu;

        public Joueur(string nom, string pion)
        {
            this.nom = nom;
            this.pion = pion;
        }
    }
}
