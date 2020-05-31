namespace Hexapawn
{
    public class JoueurIAMachineLearning : Joueur
    {

        private readonly Alternatives alternatives = new Alternatives();
        private readonly IAleatoire aleatoire;

        public JoueurIAMachineLearning(string nom, string pion, IAleatoire aleatoire) : base(nom, pion)
        {
            this.aleatoire = aleatoire;
        }
        
        override public Deplacement ChoisirDeplacement(Plateau plateau, Deplacement[] deplacementsPossibles)
        {
            return alternatives.ChoisirDeplacement(plateau.Afficher(), deplacementsPossibles, aleatoire);
        }

        override public void Apprendre(bool estVictoire)
        {
            if (!estVictoire)
            {
                alternatives.SupprimerDernierChoix();
            }
            base.Apprendre(estVictoire);
        }

    }

}
