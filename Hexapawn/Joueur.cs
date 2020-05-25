using System;
namespace Hexapawn
{
    public class Joueur
    {
        public string nom;
        public string pion;
        public int LigneDepart;

        public Joueur(string nom, string pion)
        {
            this.nom = nom;
            this.pion = pion;
        }
    }
}
