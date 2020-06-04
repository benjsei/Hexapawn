using System.Collections.Generic;
using Hexapawn.Jeu.Joueurs;

namespace Hexapawn.Jeu.Plateau.Regles
{
    public class ReglesDeplacement
    {
        private readonly Damier damier;

        public ReglesDeplacement(Damier damier)
        {
            this.damier = damier;
        }

        public Deplacement[] DeplacementsPossibles(Joueur joueur)
        {
            var deplacements = new List<Deplacement>();

            foreach(Position position in damier.Positions)
            {
                var deplacementsPourCetteCase = DeplacementsPourCetteCase(joueur, position);
                deplacements.AddRange(deplacementsPourCetteCase);
            }

            return deplacements.ToArray();
        }

        private Deplacement[] DeplacementsPourCetteCase(Joueur joueur, Position depart)
        {
            var deplacements = new List<Deplacement>();

            if (damier.CaseContientPion(joueur.pion, depart))
            {
                Position nouvellePosition = joueur.AvancerPosition(depart);

                if (DeplacerSiPossible(nouvellePosition) is Position fin)
                {
                    deplacements.Add(new Deplacement(depart, fin));
                }

                if (PendreSiPossible(joueur, nouvellePosition, SensDePrise.ADroite) is Position finADroite)
                {
                    deplacements.Add(new Deplacement(depart, finADroite));
                }

                if (PendreSiPossible(joueur, nouvellePosition, SensDePrise.AGauche) is Position finAGauche)
                {
                    deplacements.Add(new Deplacement(depart, finAGauche));
                }

            }

            return deplacements.ToArray();
        }

        private Position DeplacerSiPossible(Position position)
        {
            if (damier.CaseEstVide(position))
            {
                return position;
            }

            return null;
        }

        private Position PendreSiPossible(Joueur joueur, Position position, SensDePrise sensDePrise)
        {
            int nouvelleColonne = position.Colonne + (int)sensDePrise;
            Position nouvellePosition = new Position(position.Ligne, nouvelleColonne);

            if (damier.CaseContientPionAdvserse(joueur.pion, nouvellePosition))
            {
                return nouvellePosition;
            }

            return null;
        }
    }
}
