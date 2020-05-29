namespace Hexapawn
{
    public class JoueurIAMachineLearning : Joueur
    {

        private readonly Alternatives alternatives = new Alternatives();

        public JoueurIAMachineLearning(string nom, string pion, IAleatoire aleatoire) : base(nom, pion, aleatoire)
        {

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
