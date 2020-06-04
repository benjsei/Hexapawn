using System.Collections.Generic;
using Hexapawn.Jeu.Plateau;

namespace Hexapawn.Jeu.Joueur.IA
{
    public class Alternatives : List<Alternative>
    {
        private Choix dernierChoix;

        public Deplacement ChoisirDeplacement(string plateau, Deplacement[] deplacementsPossibles, IAleatoire aleatoire)
        {
            foreach (Alternative alternative in this)
            {
                if (alternative.Plateau == plateau)
                {
                    dernierChoix = alternative.Choisir();
                    return dernierChoix.Deplacement;
                }
            }

            return EnregistrerEtChoisirAleatoirementDeplacement(plateau, deplacementsPossibles, aleatoire);
        }

        public void SupprimerDernierChoix()
        {
            foreach (Alternative alternative in this)
            {
                if (dernierChoix.EstMemePlateau(alternative.Plateau)
                    && (alternative.APlusieursDeplacementsRestants))
                {
                    _ = alternative.Deplacements.Remove(dernierChoix.Deplacement);
                }
            }
        }

        public Deplacement EnregistrerEtChoisirAleatoirementDeplacement(string plateau, Deplacement[] deplacementsPossibles, IAleatoire aleatoire)
        {
            Alternative alternative = new Alternative(plateau, deplacementsPossibles, aleatoire);
            this.Add(alternative);

            dernierChoix = alternative.Choisir();
            return dernierChoix.Deplacement;
        }

    }

}
