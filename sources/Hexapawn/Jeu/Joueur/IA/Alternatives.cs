using System.Collections.Generic;
using Hexapawn.Jeu.Plateau;

namespace Hexapawn.Jeu.Joueurs.IA
{
    public class Alternatives : List<Alternative>
    {
        private Choix dernierChoix;

        public void SupprimerDernierChoix()
        {
            foreach (Alternative alternative in this)
            {
                SupprimerSiMemePlateauEtNEstPasLaDerniere(alternative);
            }
        }

        public Deplacement ChoisirDeplacement(string plateau, Deplacement[] deplacementsPossibles, IAleatoire aleatoire)
        {
            var alternativesForPlateau = this.FindAll(a => a.EstMemePlateau(plateau));

            if (alternativesForPlateau.Premier() is Alternative premierAlternative)
            {
                dernierChoix = premierAlternative.Choisir();
                return dernierChoix.Deplacement;
            }

            return EnregistrerEtChoisirAleatoirementDeplacement(plateau, deplacementsPossibles, aleatoire);
        }

        public Deplacement EnregistrerEtChoisirAleatoirementDeplacement(string plateau, Deplacement[] deplacementsPossibles, IAleatoire aleatoire)
        {
            Alternative alternative = new Alternative(plateau, deplacementsPossibles, aleatoire);
            this.Add(alternative);

            dernierChoix = alternative.Choisir();
            return dernierChoix.Deplacement;
        }

        private void SupprimerSiMemePlateauEtNEstPasLaDerniere(Alternative alternative)
        {
            var aMemePlateauEtNEstPasLaDerniere = dernierChoix.AMemePlateau(alternative)
                    && (alternative.APlusieursDeplacementsRestants);

            if (aMemePlateauEtNEstPasLaDerniere)
            {
                alternative.Deplacements.Remove(dernierChoix.Deplacement);
            }
        }
    }

}
