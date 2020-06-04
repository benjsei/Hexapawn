using System;
using Hexapawn.Jeu.Plateau;

namespace Hexapawn.Jeu.Joueurs
{
    public class JoueurAleatoire : Joueur
    {
        private readonly IAleatoire aleatoire;

        public JoueurAleatoire(string nom, string pion, IAleatoire aleatoire) : base(nom, pion)
        {
            this.aleatoire = aleatoire;
        }

        public override Deplacement ChoisirDeplacement(IPlateau plateau, Deplacement[] deplacementsPossibles)
        {
            int indexAleatoire = aleatoire.ChiffreAleatoire(deplacementsPossibles.Length);
            if (indexAleatoire < deplacementsPossibles.Length)
            {
                return deplacementsPossibles[indexAleatoire];
            }
            return (Deplacement)deplacementsPossibles.PremierSinonVide();
        }
    }
}
