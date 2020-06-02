using System;
namespace Hexapawn
{
    public class Partie
    {
        private const int nombreJoueur = 2;
        private readonly Joueur joueur1;
        private readonly Joueur joueur2;
        private readonly IPartieInterface partieInterface;
        private readonly IAleatoire aleatoire;

        public Partie(Joueur joueur1, Joueur joueur2, IPartieInterface partieInterface, IAleatoire aleatoire)
        {
            this.joueur1 = joueur1;
            this.joueur2 = joueur2;
            this.partieInterface = partieInterface;
            this.aleatoire = aleatoire;
        }

        public void Jouer()
        {
            Plateau plateau = new Plateau(joueur1, joueur2)
            {
                JoueurActif = TirerAuSortPremierJoueur()
            };

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

            bool joueur1Gagnant = plateau.gagnant == joueur1;
            joueur1.Apprendre(joueur1Gagnant);
            joueur2.Apprendre(!joueur1Gagnant);

            partieInterface.AfficherGagnant(plateau.gagnant);
        }

        private Joueur TirerAuSortPremierJoueur()
        {
            return aleatoire.ChiffreAleatoire(nombreJoueur) == 1 ? joueur1 : joueur2;
        }
    }
}
