using Hexapawn.Jeu.Plateau;

namespace Hexapawn.Jeu.Joueurs.IA
{
    public class Choix
    {
        private readonly string plateau;

        public readonly Deplacement Deplacement;

        public Choix(string plateau, Deplacement deplacement)
        {
            this.plateau = plateau;
            this.Deplacement = deplacement;
        }

        public bool AMemePlateau(Alternative alternative)
        {
            return  alternative.EstMemePlateau( plateau);
        }
    }

}
