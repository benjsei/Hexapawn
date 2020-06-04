using Hexapawn.Jeu.Joueurs.Humain;
using Hexapawn.Jeu.Plateau;

namespace Hexapawn.Jeu.Joueurs
{
    public class JoueurHumain : Joueur
    {

        private IJoueurHumainInterface joueurHumainInterface;

        public JoueurHumain(string nom, string pion, IJoueurHumainInterface joueurHumainInterface) : base(nom, pion)
        {
            this.joueurHumainInterface = joueurHumainInterface;
        }


        public override Deplacement ChoisirDeplacement(IPlateau plateau, Deplacement[] deplacementsPossibles)
        {
            int saisie = joueurHumainInterface.DemanderDeplacement(plateau, deplacementsPossibles);
            if (saisie < deplacementsPossibles.Length)
            {
                return deplacementsPossibles[saisie];
            }
            return (Deplacement)deplacementsPossibles.PremierSinonVide();
        }
    }
}
