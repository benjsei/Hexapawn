using System;
using System.Collections.Generic;

namespace Hexapawn
{
    public class Plateau
    {
        private const int taille = 3;
        private const string caseVide = "_";
        private const int ligneDepartJoueurHaut = 0;
        private const int ligneDepartJoueurBas = taille - 1;

        private readonly Joueur joueurHaut;
        private readonly Joueur joueurBas;

        private Joueur dernierJoueur;
        private Joueur prochainJoueur
        {
            get
            {
                if (dernierJoueur == joueurHaut) {
                    return joueurBas;
                }

                if (dernierJoueur == joueurBas)
                {
                    return joueurHaut;
                }

                return null;
            }
        }

        private string[,] damier = new string[taille, taille];

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
            for (int ligne = 0; ligne < taille; ligne++)
            {
                affichage += AfficherColonne(ligne);
            }

            return affichage;
        }

        public void BougerPion(Joueur joueur, Position depart, Position arrivee)
        {
            if (damier[depart.Ligne, depart.Colonne] == joueur.pion) {

                damier[depart.Ligne, depart.Colonne] = caseVide;
                damier[arrivee.Ligne, arrivee.Colonne] = joueur.pion;
                dernierJoueur = joueur;
            } 
        }

        public String AfficherColonne(int ligne)
        {
            var affichageColonne = String.Empty;
            for (int colonne = 0; colonne < taille; colonne++)
            {
                affichageColonne += damier[ligne, colonne];
            }

            return affichageColonne;
        }

        public Deplacement[] DeplacementsPossibles(Joueur joueur)
        {
            var deplacements = new List<Deplacement>();

            for (int ligne = 0; ligne < taille; ligne++)
            {
                for (int colonne = 0; colonne < taille; colonne++)
                {
                    var deplacementsPourCetteCase = DeplacementsPourCetteCase(joueur, ligne, colonne);
                    deplacements.AddRange(deplacementsPourCetteCase);
                }
            }

            return deplacements.ToArray();
        }

        public void Restaurer(String plateau)
        {
            for (int i = 0; i < taille * taille; i++)
            {
                int ligne = i / taille;
                int colonne = i - taille * ligne;
                damier[ligne, colonne] = plateau[i].ToString();
            }
        }

        public Joueur gagnant
        {
            get
            {
                if (EstDetruit(prochainJoueur))
                {
                    return dernierJoueur;
                }

                if (AConquis(dernierJoueur))
                {
                    return dernierJoueur;
                }

                if (EstBloque(prochainJoueur))
                {
                    return dernierJoueur;
                }

                return null;
            }
        }

        private bool EstBloque(Joueur joueur)
        {
            return DeplacementsPossibles(joueur).Length == 0;
        }

        private bool AConquis(Joueur joueur)
        {
            int ligne = LigneDArrivee(joueur);
            for (int colonne = 0; colonne < taille; colonne++)
            {
                if (damier[ligne, colonne] == joueur.pion)
                {
                    return true;
                }
            }

            return false;
        }

        private bool EstDetruit(Joueur joueur)
        {
            return !Trouver(joueur.pion);
        }

        private bool Trouver(String pion)
        {
            for (int ligne = 0; ligne < taille; ligne++)
            {
                for (int colonne = 0; colonne < taille; colonne++)
                {
                    if (damier[ligne, colonne] == pion)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private Deplacement[] DeplacementsPourCetteCase(Joueur joueur, int ligne, int colonne)
        {
            var deplacements = new List<Deplacement>();

            if (damier[ligne, colonne] == joueur.pion)
            {
                Position depart = new Position(ligne, colonne);

                int nouvelleLigne = ligne + joueur.IncrementDeplacement;

                if (DeplacerSiPossible(colonne, nouvelleLigne) is Position fin)
                {
                    deplacements.Add(new Deplacement(depart, fin));
                }

                if (PendreSiPossible(joueur, colonne, nouvelleLigne, SensDePrise.ADroite) is Position finADroite)
                {
                    deplacements.Add(new Deplacement(depart, finADroite));
                }

                if (PendreSiPossible(joueur, colonne, nouvelleLigne, SensDePrise.AGauche) is Position finAGauche)
                {
                    deplacements.Add(new Deplacement(depart, finAGauche));
                }

            }

            return deplacements.ToArray();
        }

        private Position DeplacerSiPossible(int colonne, int nouvelleLigne)
        {
            if (damier[nouvelleLigne, colonne] == caseVide)
            {
                return new Position(nouvelleLigne, colonne);
            }

            return null;
        }

        private Position PendreSiPossible(Joueur joueur, int colonne, int nouvelleLigne, SensDePrise sensDePrise)
        {
            int nouvelleColonne = colonne + (int)sensDePrise;

            if (nouvelleColonne >= 0 &&
                nouvelleColonne < taille &&
                damier[nouvelleLigne, nouvelleColonne] != caseVide &&
                damier[nouvelleLigne, nouvelleColonne] != joueur.pion)
            {

                return new Position(nouvelleLigne, nouvelleColonne);
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
            for (int ligne = 0; ligne < taille; ligne++)
            {
                ViderColonne(ligne);
            }
        }

        private void ViderColonne(int ligne)
        {
            for (int colonne = 0; colonne < taille; colonne++)
            {
                damier[ligne, colonne] = caseVide;
            }
        }

        private void MettreEnPlace(Joueur joueur)
        {
            for (int colonne = 0; colonne < taille; colonne++)
            {
                int ligneDeDepart = LigneDeDepart(joueur);

                damier[ligneDeDepart, colonne] = joueur.pion;
            }
        }

        private int LigneDeDepart(Joueur joueur)
        {
            if (joueur.sensDeJeu == SensDeJeu.BasVersHaut)
            {
                return ligneDepartJoueurBas;
            }

            return ligneDepartJoueurHaut;
        }

        private int LigneDArrivee(Joueur joueur)
        {
            if (joueur.sensDeJeu == SensDeJeu.BasVersHaut)
            {
                return ligneDepartJoueurHaut;
            }

            return ligneDepartJoueurBas;
        }
    }
}
