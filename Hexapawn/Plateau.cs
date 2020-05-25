using System;
namespace Hexapawn
{
    public class Plateau
    {
        private const int taille = 3;
        private const string vide = "_";
        private const string pionJoueur = "1";
        private const string pionIA = "2";
        private const int ligneJoueur = 1;
        private const int ligneIA = taille;
        private string[,] damier = new string[taille, taille];

        public Plateau()
        {
            Demarrer();
        }

        public String Afficher()
        {
            var affichage = String.Empty;
            for (int ligne = 0; ligne < damier.GetLength(0); ligne++)
            {
                affichage += AfficherColonne(ligne);
            }

            return affichage;
        }

        public void BougerPionJoueur(Position depart, Position arrivee)
        {
            if (damier[depart.Ligne - 1, depart.Colonne - 1] == pionJoueur) {

                damier[depart.Ligne - 1, depart.Colonne - 1] = vide;
                damier[arrivee.Ligne - 1, arrivee.Colonne - 1] = pionJoueur;
            } 
        }

        public Deplacement[] ListerDeplacementPossibles()
        {
            var deplacements = new Deplacement[] { };

            return deplacements;
        }

        public String AfficherColonne(int ligne)
        {
            var affichageColonne = String.Empty;
            for (int colonne = 0; colonne < damier.GetLength(1); colonne++)
            {
                affichageColonne += damier[ligne, colonne];
            }

            return affichageColonne;
        }

        private void Demarrer()
        {
            Vider();
            MettreEnPlace(pionJoueur, ligneJoueur);
            MettreEnPlace(pionIA, ligneIA);
        }

        private void Vider()
        {
            for (int ligne = 0; ligne < damier.GetLength(0); ligne++)
            {
                ViderColonne(ligne);
            }
        }

        private void ViderColonne(int ligne)
        {
            for (int colonne = 0; colonne < damier.GetLength(1); colonne++)
            {
                damier[ligne, colonne] = vide;
            }
        }

        private void MettreEnPlace(string pion, int ligne)
        {
            for (int colonne = 0; colonne < damier.GetLength(1); colonne++)
            {
                damier[ligne - 1, colonne] = pion;
            }
        }

    }
}
