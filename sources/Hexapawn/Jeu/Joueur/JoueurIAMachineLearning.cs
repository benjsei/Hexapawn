using System;
using Hexapawn.Jeu.Joueurs.IA;
using Hexapawn.Jeu.Plateau;

namespace Hexapawn.Jeu.Joueurs
{
    public class JoueurIAMachineLearning : Joueur
    {
        private readonly Alternatives alternatives = new Alternatives();
        private readonly IAleatoire aleatoire;

        public JoueurIAMachineLearning(string nom, string pion, IAleatoire aleatoire) : base(nom, pion)
        {
            this.aleatoire = aleatoire;
        }

        public override Deplacement ChoisirDeplacement(IPlateau plateau, Deplacement[] deplacementsPossibles)
        {
            return alternatives.ChoisirDeplacement(plateau.Afficher(), deplacementsPossibles, aleatoire);
        }

        public override void Apprendre(bool estVictoire)
        {
            if (!estVictoire)
            {
                alternatives.SupprimerDernierChoix();
            }
            base.Apprendre(estVictoire);
        }

    }

}
