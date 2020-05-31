using System;
namespace Hexapawn
{
    public class Partie
    {
        private int nombreJoueur = 2;
        public Joueur joueur1;
        public Joueur joueur2;

        private readonly Aleatoire aleatoire = new Aleatoire();

        private Joueur JoueurAleatoire
        {
            get
            {
                return aleatoire.ChiffreAleatoire(nombreJoueur) == 1 ? joueur1 : joueur2;
            }
        }

        public Partie(Joueur joueur1, Joueur joueur2)
        {
            this.joueur1 = joueur1;
            this.joueur2 = joueur2;
        }

        public void Jouer()
        {
            Plateau plateau = new Plateau(joueur1, joueur2)
            {
                JoueurActif = JoueurAleatoire
            };

            while (true)
            {
                plateau.Jouer();

                if (plateau.EstTerminee)
                {
                    bool joueur1Gagnant = plateau.gagnant == joueur1;
                    joueur1.Apprendre(joueur1Gagnant);
                    joueur2.Apprendre(!joueur1Gagnant);

                    Console.Write("Le gagnant est : " + plateau.gagnant.nom + "\n");
                    break;
                }
                else
                {
                    plateau.AuJoueurSuivant();
                }
            }
        }



        
    }
}
