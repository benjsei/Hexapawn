namespace Hexapawn
{
    public class JoueurHumain : Joueur
    {

        private IJoueurHumainInterface joueurHumainInterface;

        public JoueurHumain(string nom, string pion, IJoueurHumainInterface joueurHumainInterface) : base(nom, pion)
        {
            this.joueurHumainInterface = joueurHumainInterface;
        }
        
        override public Deplacement ChoisirDeplacement(Plateau plateau, Deplacement[] deplacementsPossibles)
        {
            int saisie = joueurHumainInterface.DemanderDeplacement(plateau, deplacementsPossibles);

            return deplacementsPossibles[saisie];
        }
    }
}
