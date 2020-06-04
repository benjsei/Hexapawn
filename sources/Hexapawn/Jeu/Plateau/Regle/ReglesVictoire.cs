namespace Hexapawn.Jeu.Plateau.Regle
{
    class ReglesVictoire
    {
        private readonly ReglesDeplacement reglesDeplacement;
        private readonly Damier damier;

        public ReglesVictoire(ReglesDeplacement reglesDeplacement, Damier damier)
        {
            this.reglesDeplacement = reglesDeplacement;
            this.damier = damier;
        }

        public bool EstBloque(Joueurs.Joueur joueur)
        {
            return reglesDeplacement.DeplacementsPossibles(joueur).Length == 0;
        }

        public bool AConquis(Joueurs.Joueur joueur)
        {
            foreach(Position position in damier.PositionsDArrivee(joueur))
            {
                if (damier.CaseContientPion(joueur.pion, position))
                {
                    return true;
                }
            }

            return false;
        }

        public bool EstDetruit(Joueurs.Joueur joueur)
        {
            return !damier.Trouver(joueur.pion);
        }
    }
}
