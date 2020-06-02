using System;

namespace Hexapawn
{
    public class Partie
    {
        private readonly IPlateau plateau;
        private readonly IPartieInterface partieInterface;
        private readonly IAleatoire aleatoire;

        public Partie(IPlateau plateau, IPartieInterface partieInterface, IAleatoire aleatoire)
        {
            this.plateau = plateau;
            this.partieInterface = partieInterface;
            this.aleatoire = aleatoire;
        }

        public void Jouer()
        {
            plateau.SelectionnerJoueurActif(aleatoire.VraiOuFauxAleatoire());

            bool partieEncours = true;
            
            while (partieEncours)
            {
                plateau.Jouer();

                partieEncours = plateau.EstPasTerminee;
                if (partieEncours)
                {
                    plateau.AuJoueurSuivant();
                }
            }

            plateau.Enseigner();

            partieInterface.AfficherResultat(plateau.Gagnant);
        }
    }
}
