using System;
using System.Collections.Generic;

namespace Hexapawn
{
    public class Plateau
    {
        private const int taille = 3;
        private const string vide = "_";
        private const int ligneDepartJoueurHaut = 0;
        private const int ligneDepartJoueurBas = taille - 1;
        private const int incrementDeDeplacement = 1;

        private readonly Joueur joueurHaut;
        private readonly Joueur joueurBas;

        private string[,] damier = new string[taille, taille];

        private int nombreLignes()
        {
            return damier.GetLength(0);
        }

        private int nombreColonnes()
        {
            return damier.GetLength(1);
        }

        public Plateau(Joueur joueurHaut, Joueur joueurBas)
        {
            joueurHaut.sensDeJeu = SensDeJeu.HautVersBas;
            this.joueurHaut = joueurHaut;

            joueurBas.sensDeJeu = SensDeJeu.BasVersHaut;
            this.joueurBas = joueurBas;

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

        public void BougerPion(Joueur joueur, Position depart, Position arrivee)
        {
            if (damier[depart.Ligne - 1, depart.Colonne - 1] == joueur.pion) {

                damier[depart.Ligne - 1, depart.Colonne - 1] = vide;
                damier[arrivee.Ligne - 1, arrivee.Colonne - 1] = joueur.pion;
            } 
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

        public Deplacement[] DeplacementsPossibles(Joueur joueur)
        {
            var deplacements = new List<Deplacement>();

            for (int ligne = 0; ligne < nombreLignes(); ligne++)
            {
                for (int colonne = 0; colonne < nombreColonnes(); colonne++)
                {
                    if (SiDeplacementPossible(joueur, ligne, colonne) is Deplacement deplacement) {
                        deplacements.Add(deplacement);
                    }
                }
            }

            return deplacements.ToArray();
        }

        private Deplacement SiDeplacementPossible(Joueur joueur, int ligne, int colonne)
        {
            if (damier[ligne, colonne] == joueur.pion)
            {
                int nouvelleLigne = ligne + IncrementDeplacement(joueur);

                Position depart = new Position(ligne, colonne);
                Position fin = new Position(nouvelleLigne, colonne);


                return new Deplacement(depart, fin);
            }

            return null;
        }

        private void Demarrer()
        {
            Vider();
            MettreEnPlace(joueurHaut);
            MettreEnPlace(joueurBas);
        }

        private void Vider()
        {
            for (int ligne = 0; ligne < nombreLignes(); ligne++)
            {
                ViderColonne(ligne);
            }
        }

        private void ViderColonne(int ligne)
        {
            for (int colonne = 0; colonne < nombreColonnes(); colonne++)
            {
                damier[ligne, colonne] = vide;
            }
        }

        private void MettreEnPlace(Joueur joueur)
        {
            for (int colonne = 0; colonne < nombreColonnes() ; colonne++)
            {
                int ligneDeDepart = LigneDeDepart(joueur);

                damier[ligneDeDepart, colonne] = joueur.pion;
            }
        }

        private int IncrementDeplacement(Joueur joueur)
        {
            if (joueur.sensDeJeu == SensDeJeu.BasVersHaut)
            {
                return -1 * incrementDeDeplacement;
            }

            return incrementDeDeplacement;
        }

        private int LigneDeDepart(Joueur joueur)
        {
            if (joueur.sensDeJeu == SensDeJeu.BasVersHaut)
            {
                return ligneDepartJoueurBas;
            }

            return ligneDepartJoueurHaut;
        }

    }

}
