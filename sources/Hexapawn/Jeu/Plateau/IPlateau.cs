using Hexapawn.Jeu.Joueurs;

namespace Hexapawn.Jeu.Plateau
{
    public interface IPlateau
    {
        bool EstPasTerminee { get; }
        Joueurs.Joueur Gagnant { get; }
        void SelectionnerJoueurActif(bool face);
        void PasserAuJoueurSuivant();
        void JouerJoueurActif();
        void Enseigner();
        string Afficher();
    }
}
