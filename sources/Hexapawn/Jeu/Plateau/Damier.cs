using System;
using System.Collections.Generic;
using Hexapawn.Jeu.Joueurs;

namespace Hexapawn.Jeu.Plateau
{
    public class Damier
    {
        private const string caseVide = "_";
        private const int dimensionLigne = 0;
        private const int dimensionColonne = 1;
        private readonly string[,] cases;
        private const int ligneDepartJoueurHaut = 0;
        private readonly int ligneDepartJoueurBas;
        
        public Damier(int taille)
        {
            cases = new string[taille, taille];
            ligneDepartJoueurBas = taille - 1;
        }

        public void Restaurer(string damier)
        {
            for (int i = 0; i < NombreCases; i++)
            {
                int ligne = i / NombreColonnes;
                int colonne = i - NombreColonnes * ligne;
                cases[ligne, colonne] = damier[i].ToString();
            }
        }

        public string Afficher()
        {
            var affichage = String.Empty;
            for (int ligne = 0; ligne < NombreLignes; ligne++)
            {
                affichage += AfficherColonne(ligne);
            }

            return affichage;
        }

        public void BougerPion(string pion, Deplacement deplacement)
        {
            if (CaseContientPion(pion, deplacement.Depart) &&
                    CaseNeContientPasPion(pion, deplacement.Fin))
            {
                ViderCase(deplacement.Depart);
                AffecterCasePion(pion, deplacement.Fin);
            }
        }

        public void MettreEnPlace(Joueur joueur)
        {
            foreach(Position position in PositionsDeDepart(joueur))
            {
                AffecterCasePion(joueur.pion, position);
            }
        }

        public bool CaseContientPion(string pion, Position position)
        {
            return cases[position.Ligne, position.Colonne] == pion;
        }

        public bool CaseEstVide(Position position)
        {
            return cases[position.Ligne, position.Colonne] == caseVide;
        }

        public Position[] Positions
        {
            get
            {
                var positions = new List<Position>();

                for (int ligne = 0; ligne < NombreLignes; ligne++)
                {
                    for (int colonne = 0; colonne < NombreColonnes; colonne++)
                    {
                        positions.Add( new Position(ligne, colonne));
                    }
                }

                return positions.ToArray();
            }
        }

        public bool CaseContientPionAdvserse(string pion, Position position)
        {
            return position.Colonne >= 0 &&
                position.Colonne < NombreColonnes &&
                CaseNEstPasVide(position) &&
                CaseNeContientPasPion(pion, position);
        }

        public bool NeTrouvePas(string pion)
        {
            for (int ligne = 0; ligne < NombreLignes; ligne++)
            {
                if (NeTrouvePasColonne(pion, ligne))
                {
                    return false;
                }
            }

            return true;
        }

        public void Vider()
        {
            for (int ligne = 0; ligne < NombreLignes; ligne++)
            {
                ViderColonne(ligne);
            }
        }

        public Position[] PositionsDArrivee(Joueur joueur)
        {
            int ligne = LigneDArrivee(joueur);
            return PositionsDUneLigne(ligne);
        }

        private int NombreLignes
        {
            get
            {
                return cases.GetLength(dimensionLigne);
            }
        }

        private int NombreColonnes
        {
            get
            {
                return cases.GetLength(dimensionColonne);
            }
        }

        private int NombreCases
        {
            get
            {
                return NombreLignes * NombreColonnes;
            }
        }

        private bool CaseNeContientPasPion(string pion, Position position)
        {
            return cases[position.Ligne, position.Colonne] != pion;
        }

        private bool CaseNEstPasVide(Position position)
        {
            return !CaseEstVide(position);
        }

        private void AffecterCasePion(string pion, Position position)
        {
            cases[position.Ligne, position.Colonne] = pion;
        }

        private void ViderCase(Position position)
        {
            cases[position.Ligne, position.Colonne] = caseVide;
        }

        private bool NeTrouvePasColonne(string pion, int ligne)
        {
            for (int colonne = 0; colonne < NombreColonnes; colonne++)
            {
                if (cases[ligne, colonne] == pion)
                {
                    return false;
                }
            }

            return true;
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

        private void ViderColonne(int ligne)
        {
            for (int colonne = 0; colonne < NombreColonnes; colonne++)
            {
                cases[ligne, colonne] = caseVide;
            }
        }

        private Position[] PositionsDeDepart(Joueur joueur)
        {
            int ligne = LigneDeDepart(joueur);
            return PositionsDUneLigne(ligne);
        }

        private int LigneDeDepart(Joueur joueur)
        {
            if (joueur.sensDeJeu == SensDeJeu.BasVersHaut)
            {
                return ligneDepartJoueurBas;
            }

            return ligneDepartJoueurHaut;
        }

        private Position[] PositionsDUneLigne(int ligne)
        {
            var positions = new List<Position>();
            for (int colonne = 0; colonne < NombreColonnes; colonne++)
            {
                positions.Add(new Position(ligne, colonne));
            }
            return positions.ToArray();
        }

        private int LigneDArrivee(Joueur joueur) { 
      
            if (joueur.sensDeJeu == SensDeJeu.BasVersHaut)
            {
                return ligneDepartJoueurHaut;
            }

            return ligneDepartJoueurBas;
        }
    }
}
