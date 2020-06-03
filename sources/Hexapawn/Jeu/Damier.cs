using System;
using System.Collections.Generic;

namespace Hexapawn
{
    public class Damier
    {
        private const string caseVide = "_";
        private const int dimensionLigne = 0;
        private const int dimensionColonne = 1;
        private readonly string[,] cases;
        private const int ligneDepartJoueurHaut = 0;
        private readonly int ligneDepartJoueurBas;

        internal Damier(int taille)
        {
            cases = new string[taille, taille];
            ligneDepartJoueurBas = taille - 1;
        }

        internal void Restaurer(string damier)
        {
            for (int i = 0; i < NombreCases; i++)
            {
                int ligne = i / NombreColonnes;
                int colonne = i - NombreColonnes * ligne;
                cases[ligne, colonne] = damier[i].ToString();
            }
        }

        internal string Afficher()
        {
            var affichage = String.Empty;
            for (int ligne = 0; ligne < NombreLignes; ligne++)
            {
                affichage += AfficherColonne(ligne);
            }

            return affichage;
        }

        internal void BougerPion(string pion, Deplacement deplacement)
        {
            if ((cases[deplacement.Depart.Ligne, deplacement.Depart.Colonne] == pion) &&
                    (cases[deplacement.Fin.Ligne, deplacement.Fin.Colonne] != pion))
            {

                cases[deplacement.Depart.Ligne, deplacement.Depart.Colonne] = caseVide;
                cases[deplacement.Fin.Ligne, deplacement.Fin.Colonne] = pion;
            }
        }


        internal Deplacement[] DeplacementsPossibles(Joueur joueur)
        {
            var deplacements = new List<Deplacement>();

            for (int ligne = 0; ligne < NombreLignes; ligne++)
            {
                for (int colonne = 0; colonne < NombreColonnes; colonne++)
                {
                    var deplacementsPourCetteCase = DeplacementsPourCetteCase(joueur, ligne, colonne);
                    deplacements.AddRange(deplacementsPourCetteCase);
                }
            }

            return deplacements.ToArray();
        }

        internal bool EstBloque(Joueur joueur)
        {
            return DeplacementsPossibles(joueur).Length == 0;
        }

        internal bool AConquis(Joueur joueur)
        {
            int ligne = LigneDArrivee(joueur);
            for (int colonne = 0; colonne < NombreColonnes; colonne++)
            {
                if (cases[ligne, colonne] == joueur.pion)
                {
                    return true;
                }
            }

            return false;
        }

        internal bool EstDetruit(Joueur joueur)
        {
            return !Trouver(joueur.pion);
        }

        internal void MettreEnPlace(Joueur joueur)
        {
            for (int colonne = 0; colonne < NombreColonnes; colonne++)
            {
                int ligneDeDepart = LigneDeDepart(joueur);

                cases[ligneDeDepart, colonne] = joueur.pion;
            }
        }

        private bool Trouver(string pion)
        {
            for (int ligne = 0; ligne < NombreLignes; ligne++)
            {
                for (int colonne = 0; colonne < NombreColonnes; colonne++)
                {
                    if (cases[ligne, colonne] == pion)
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

            if (cases[ligne, colonne] == joueur.pion)
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
            if (cases[nouvelleLigne, colonne] == caseVide)
            {
                return new Position(nouvelleLigne, colonne);
            }

            return null;
        }

        private Position PendreSiPossible(Joueur joueur, int colonne, int nouvelleLigne, SensDePrise sensDePrise)
        {
            int nouvelleColonne = colonne + (int)sensDePrise;

            if (nouvelleColonne >= 0 &&
                nouvelleColonne < NombreColonnes &&
                cases[nouvelleLigne, nouvelleColonne] != caseVide &&
                cases[nouvelleLigne, nouvelleColonne] != joueur.pion)
            {

                return new Position(nouvelleLigne, nouvelleColonne);
            }

            return null;
        }

        private string AfficherColonne(int ligne)
        {
            var affichageColonne = String.Empty;
            for (int colonne = 0; colonne < NombreColonnes; colonne++)
            {
                affichageColonne += cases[ligne, colonne];
            }

            return affichageColonne;
        }

        public void Vider()
        {
            for (int ligne = 0; ligne < NombreLignes; ligne++)
            {
                ViderColonne(ligne);
            }
        }

        private void ViderColonne(int ligne)
        {
            for (int colonne = 0; colonne < NombreColonnes; colonne++)
            {
                cases[ligne, colonne] = caseVide;
            }
        }

        private int NombreLignes
        {
            get
            {
                return this.cases.GetLength(dimensionLigne);
            }
        }

        private int NombreColonnes
        {
            get
            {
                return this.cases.GetLength(dimensionColonne);
            }
        }


        private int NombreCases
        {
            get
            {
                return NombreLignes * NombreColonnes;
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
