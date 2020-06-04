using Hexapawn.Jeu.Plateau;

namespace Hexapawn.Jeu.Joueurs.IA
{
    public class Choix
    {
        private readonly string Plateau;

        public readonly Deplacement Deplacement;

        public Choix(string Plateau, Deplacement Deplacement)
        {
            this.Plateau = Plateau;
            this.Deplacement = Deplacement;
        }

        public bool EstMemePlateau(string AutrePlateau)
        {
            return AutrePlateau == Plateau;
        }
    }

}
