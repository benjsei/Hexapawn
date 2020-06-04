using System;
using Hexapawn.Jeu.Plateau;

namespace Hexapawn.Jeu.Partie
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
            plateau.SelectionnerJoueurActif(aleatoire.RecupererVraiOuFaux());

            bool partieEncours = true;
            
            while (partieEncours)
            {
                plateau.JouerJoueurActif();

                partieEncours = plateau.EstPasTerminee;
                if (partieEncours)
                {
                    plateau.PasserAuJoueurSuivant();
                }
            }

            plateau.Enseigner();

            partieInterface.AfficherResultat(plateau.Gagnant);
        }
    }
}
