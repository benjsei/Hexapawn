using System;
namespace Hexapawn
{
    public class JoueurAleatoire : Joueur
    {

        public JoueurAleatoire(string nom, string pion, IAleatoire aleatoire) : base(nom, pion, aleatoire)
        {

        }

        public override Deplacement ChoisirDeplacement(Plateau plateau, Deplacement[] deplacementsPossibles)
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
