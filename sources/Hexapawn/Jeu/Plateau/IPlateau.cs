using Hexapawn.Jeu.Joueurs;

namespace Hexapawn.Jeu.Plateau
{
    public interface IPlateau
    {
        bool EstPasTerminee { get; }
        Joueur Gagnant { get; }
        void SelectionnerJoueurActif(bool face);
        void AuJoueurSuivant();
        void Jouer();
        void Enseigner();
        string Afficher();
    }
}
