using System;
using System.Collections.Generic;
using Hexapawn.Jeu.Joueurs;

namespace Hexapawn.Jeu.Plateau
{
    public class Damier
    {
        private readonly string[,] cases;
        private const int ligneDepartJoueurHaut = 0;
        private readonly int ligneDepartJoueurBas;
        
        public Damier(int taille)
        {
            cases = new string[taille, taille];
            ligneDepartJoueurBas = taille - 1;
        }

        public void BougerPion(string pion, Deplacement deplacement)
        {
            if (cases.Contient(pion, deplacement.Depart) &&
                    cases.ContientPas(pion, deplacement.Fin))
            {
                cases.Vider(deplacement.Depart);
                cases.Affecter(pion, deplacement.Fin);
            }
        }

        public void MettreEnPlace(Joueur joueur)
        {
            foreach(Position position in PositionsDeDepart(joueur))
            {
                cases.Affecter(joueur.pion, position);
            }
        }

        public bool CaseContientPion(string pion, Position position)
        {
            return cases.Contient(pion, position);
        }

        public Position[] Positions
        {
            get
            {
                var positions = new List<Position>();

                for (int ligne = 0; ligne < cases.NombreLignes(); ligne++)
                {
                    for (int colonne = 0; colonne < cases.NombreColonnes(); colonne++)
                    {
                        positions.Add( new Position(ligne, colonne));
                    }
                }

                return positions.ToArray();
            }
        }

        public bool Trouver(string pion)
        {
            for (int ligne = 0; ligne < cases.NombreLignes(); ligne++)
            {
                if (TrouverColonne(pion, ligne))
                {
                    return true;
                }
            }

            return false;
        }

        public string Afficher()
        {
            return cases.Afficher();
        }

        public void Restaurer(string damier)
        {
            cases.Restaurer(damier);
        }

        public Position[] PositionsDArrivee(Joueur joueur)
        {
            int ligne = LigneDArrivee(joueur);
            return PositionsDUneLigne(ligne);
        }

        public void Vider()
        {
            cases.Vider();
        }

        public bool CaseEstVide(Position position)
        {
            return cases.EstVide(position);
        }

        public bool CaseContientPionAdvserse(string pion, Position position)
        {
            return cases.ContientAutre(pion, position);
        }


        private bool TrouverColonne(string pion, int ligne)
        {
            for (int colonne = 0; colonne < cases.NombreColonnes(); colonne++)
            {
                if (cases[ligne, colonne] == pion)
                {
                    return true;
                }
            }

            return false;
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
            for (int colonne = 0; colonne < cases.NombreColonnes(); colonne++)
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
